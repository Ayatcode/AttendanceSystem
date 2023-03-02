using AttendanceSystem.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Abstraction.Services;

public interface IAuthService
{
	Task CreateUserAsync(UserPostDTO userPostDTO);
	Task DeleteUserAsync(string id);
	Task<TokenResponseDTO> LoginAsync(LoginDTO loginDTO);
	Task LogOut();
}
