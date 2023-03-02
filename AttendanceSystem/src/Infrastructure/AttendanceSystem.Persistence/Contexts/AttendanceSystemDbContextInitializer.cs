using AttendanceSystem.Domain.Entities.User;
using AttendanceSystem.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Contexts;

public class AttendanceSystemDbContextInitializer
{
	private readonly AppDbContext _context;
	private readonly RoleManager<IdentityRole> _roleManager;
	private readonly UserManager<AppUser> _userManager;
	private readonly IConfiguration _configuration;

	public AttendanceSystemDbContextInitializer(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, IConfiguration configuration)
	{
		_context = context;
		_roleManager = roleManager;
		_userManager = userManager;
		_configuration = configuration;
	}
	public async Task InitializeAsync()
	{
		await _context.Database.MigrateAsync();
	}


	public async Task RoleSeedAsync()
	{

		foreach (var role in Enum.GetValues(typeof(Roles)))
		{

			if (!await _roleManager.RoleExistsAsync(role.ToString()))
			{

				await _roleManager.CreateAsync(new IdentityRole(role.ToString()));
			}
		}
	}

	public async Task UserSeedAsync()
	{
		if (_userManager.Users.Count() == 0)
		{
			AppUser userAdmin = new();
			;
			userAdmin.UserName = _configuration["AdminSettings:Username"];
			userAdmin.Email = _configuration["AdminSettings:Email"];
			
			IdentityResult identityResult = await _userManager.CreateAsync(userAdmin, _configuration["AdminSettings:Password"]);
			if (identityResult.Succeeded)
			{

			}
			await _userManager.AddToRoleAsync(userAdmin, Roles.Admin.ToString());
		}
	}
}
