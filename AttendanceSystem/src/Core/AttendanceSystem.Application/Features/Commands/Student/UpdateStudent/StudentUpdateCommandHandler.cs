using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.UpdateStudent;

public class StudentUpdateCommandHandler : IRequestHandler<StudentUpdateCommandRequest, StudentUpdateCommandResponse>
{
	private readonly IAdminService _adminService;

	public StudentUpdateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<StudentUpdateCommandResponse> Handle(StudentUpdateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.UpdateStudent(request.StudentUpdateDTO);
		return new StudentUpdateCommandResponse();
	}
}
