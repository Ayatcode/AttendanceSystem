using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.Features.Commands.Subject.DeleteSubjectl;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.DeleteSubject;

public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommandRequest, DeleteSubjectCommandResponse>
{
	private readonly IAdminService _adminService;

	public DeleteSubjectCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<DeleteSubjectCommandResponse> Handle(DeleteSubjectCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.DeleteSubject(request.Id);
		return new DeleteSubjectCommandResponse();
	}
}
