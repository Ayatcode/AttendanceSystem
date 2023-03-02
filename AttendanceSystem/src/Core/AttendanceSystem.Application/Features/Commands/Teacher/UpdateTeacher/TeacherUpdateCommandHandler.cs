using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.UpdateTeacher;

public class TeacherUpdateCommandHandler : IRequestHandler<TeacherUpdateCommandRequest, TeacherUpdateCommandResponse>
{
	private readonly IAdminService _adminService;

	public TeacherUpdateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<TeacherUpdateCommandResponse> Handle(TeacherUpdateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.UpdateTeac(request.TeacherUpdateDTO);
		return new TeacherUpdateCommandResponse();
	}
}
