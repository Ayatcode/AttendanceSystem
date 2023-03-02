using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.DTOs.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.LoginUser;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
	private readonly IAuthService _authService;

	public LoginUserCommandHandler(IAuthService authService)
	{
		_authService = authService;
	}

	public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
	{
		TokenResponseDTO tokenResponseDTO = await _authService.LoginAsync(request.LoginDTO);
		LoginUserCommandResponse response = new() { TokenResponse = tokenResponseDTO };
		return response;
	}
}
