using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.CreateSubject;

public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommandRequest, CreateSubjectCommandResponse>
{
	private readonly IAdminService _adminService;

	public CreateSubjectCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<CreateSubjectCommandResponse> Handle(CreateSubjectCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.CreateSubject(request.SubjectCreateDTO);
		return new();
	}
}
