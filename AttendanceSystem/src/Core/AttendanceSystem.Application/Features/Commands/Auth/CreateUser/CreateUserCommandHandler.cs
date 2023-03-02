using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
	private readonly IAuthService _authService;

	public CreateUserCommandHandler(IAuthService authService)
	{
		_authService = authService;
	}

	public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
	{
		await _authService.CreateUserAsync(request.UserPostDTO);
		CreateUserCommandResponse response = new();
		return response;
	}
}

