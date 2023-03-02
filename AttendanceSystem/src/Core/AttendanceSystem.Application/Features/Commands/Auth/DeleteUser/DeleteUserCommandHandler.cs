using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
{
	private readonly IAuthService _authService;

	public DeleteUserCommandHandler(IAuthService authService)
	{
		_authService = authService;
	}

	public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
	{
		await _authService.DeleteUserAsync(request.IdStr);
		DeleteUserCommandResponse response = new();
		return response;
	}
}
