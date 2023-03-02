using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.UpdateSubject;

public class SubjectUpdateCommandHandler : IRequestHandler<SubjectUpdateCommandRequest, SubjectUpdateCommandResponse>
{
	private readonly IAdminService _adminService;

	public SubjectUpdateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<SubjectUpdateCommandResponse> Handle(SubjectUpdateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.UpdateSubject(request.SubjectUpdateDTO);
		return new SubjectUpdateCommandResponse();
	}
}
