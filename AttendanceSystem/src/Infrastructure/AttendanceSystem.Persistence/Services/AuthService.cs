using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.Abstraction.Token;
using AttendanceSystem.Application.DTOs.Auth;
using AttendanceSystem.Application.Exceptions;
using AttendanceSystem.Domain.Entities.User;
using AttendanceSystem.Persistence.Contexts;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Services;

public class AuthService : IAuthService
{
	private readonly UserManager<AppUser> _userManager;
	private readonly RoleManager<IdentityRole> _roleManager;
	private readonly SignInManager<AppUser> _signInManager;
	private readonly IMapper _mapper;
	private readonly AppDbContext _context;
	private readonly ITokenHandler _tokenHandler;

	public AuthService(UserManager<AppUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager, AppDbContext context, SignInManager<AppUser> signInManager, ITokenHandler tokenHandler)
	{
		_userManager = userManager;
		_mapper = mapper;
		_roleManager = roleManager;
		_context = context;
		_signInManager = signInManager;
		_tokenHandler = tokenHandler;
	}

	public async Task CreateUserAsync(UserPostDTO userPostDTO)
	{
		AppUser baseUser = await _userManager.FindByNameAsync(userPostDTO.UserName);
		if (baseUser is not null)
		{
			throw new AlreadyRegisteredException("Already registered with this Username");
		}

		baseUser = await _userManager.FindByEmailAsync(userPostDTO.Email);
		if (baseUser is not null)
		{
			throw new AlreadyRegisteredException("Already registered with this Email");
		}




		IdentityRole? role = await _roleManager.FindByIdAsync(userPostDTO.RoleIdStr);
		if (role is null) throw new NotFoundException("Role Not found");

		AppUser user = _mapper.Map<AppUser>(userPostDTO);
		

		IdentityResult identityResult = await _userManager.CreateAsync(user, userPostDTO.Password);
		if (!identityResult.Succeeded)
		{
			string errors = String.Empty;
			int count = 0;
			foreach (var error in identityResult.Errors)
			{
				errors += count != 0 ? $",{error.Description}" : $"{error.Description}";
				count++;
			}
			throw new UserCreateFailException(errors);
		}

		IdentityResult identityResultRole = await _userManager.AddToRoleAsync(user, role.Name);
		if (!identityResultRole.Succeeded)
		{
			string errors = String.Empty;
			int count = 0;
			foreach (var error in identityResultRole.Errors)
			{
				errors += count != 0 ? $",{error.Description}" : $"{error.Description}";
				count++;
			}
			throw new AddRoleFailException(errors);
		}
	}

	public async Task DeleteUserAsync(string id)
	{
		AppUser? user = await _userManager.FindByIdAsync(id);
		if (user is null) throw new NotFoundException("User not found");
		await _userManager.DeleteAsync(user);
	}

	public async Task<TokenResponseDTO> LoginAsync(LoginDTO loginDTO)
	{
		AppUser user = await _userManager.FindByNameAsync(loginDTO.UsernameOrEmail);
		if (user is null)
		{
			user = await _userManager.FindByEmailAsync(loginDTO.UsernameOrEmail);
			if (user is null)
			{
				throw new AuthFailException();
			}
		}

		SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, true);
		if (!signInResult.Succeeded)
		{
			throw new AuthFailException();
		}
		await _signInManager.SignInAsync(user, loginDTO.RememberMe);
		TokenResponseDTO tokenResponseDTO = await _tokenHandler.GenerateTokenAsync(user);

		return tokenResponseDTO;
	}

	public async Task LogOut()
	{
		await _signInManager.SignOutAsync();
	}
}
