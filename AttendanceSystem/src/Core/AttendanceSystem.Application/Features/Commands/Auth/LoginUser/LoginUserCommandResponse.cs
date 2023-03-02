using AttendanceSystem.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.LoginUser;

public class LoginUserCommandResponse
{
	public TokenResponseDTO TokenResponse { get; set; }
}