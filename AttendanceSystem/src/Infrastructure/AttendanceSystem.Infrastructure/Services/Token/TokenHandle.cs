using AttendanceSystem.Application.Abstraction.Token;
using AttendanceSystem.Application.DTOs.Auth;
using AttendanceSystem.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Infrastructure.Services.Token;

public class TokenHandle : ITokenHandler
{
	private readonly UserManager<AppUser> _userManager;
	private readonly IConfiguration _configuration;

	public TokenHandle(UserManager<AppUser> userManager, IConfiguration configuration)
	{
		_userManager = userManager;
		_configuration = configuration;
	}

	public async Task<TokenResponseDTO> GenerateTokenAsync(AppUser user)
	{
		List<Claim> claims = new(){

			new Claim(ClaimTypes.Name, user.UserName),
			new Claim(ClaimTypes.NameIdentifier, user.Id),
			new Claim(ClaimTypes.Email, user.Email),
		};

		var roles = await _userManager.GetRolesAsync(user);
		foreach (var role in roles)
		{
			var claim = new Claim(ClaimTypes.Role, role);
			claims.Add(claim);
		}

		SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecurityKey"]));
		SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);

		JwtSecurityToken jwtSecurityToken = new(
			issuer: _configuration["JwtSettings:Issuer"],
			audience: _configuration["JwtSettings:Audience"],
			claims: claims,
			notBefore: DateTime.UtcNow,
			expires: DateTime.UtcNow.AddMinutes(3),
			signingCredentials: signingCredentials
			);

		JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
		string token = handler.WriteToken(jwtSecurityToken);

		TokenResponseDTO tokenResponseDTO = new TokenResponseDTO();
		tokenResponseDTO.Username = user.UserName;
		tokenResponseDTO.Token = token;
		tokenResponseDTO.Expires = jwtSecurityToken.ValidTo;
		return tokenResponseDTO;
	}
}