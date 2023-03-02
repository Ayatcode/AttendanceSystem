using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.DeleteTeacher;

public class TeacherDeleteCommandHandler : IRequestHandler<TeacherDeleteCommandRequest, TeacherDeleteCommandResponse>
{
	private readonly IAdminService _adminService;

	public TeacherDeleteCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<TeacherDeleteCommandResponse> Handle(TeacherDeleteCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.DeleteTeac(request.Id);
		return new();
	}
}
