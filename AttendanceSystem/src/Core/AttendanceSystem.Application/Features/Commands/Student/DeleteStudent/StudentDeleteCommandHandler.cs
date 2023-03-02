using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.DeleteStudent;

public class StudentDeleteCommandHandler : IRequestHandler<StudentDeleteCommandRequest, StudentDeleteCommandResponse>
{
	private readonly IAdminService _adminService;

	public StudentDeleteCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<StudentDeleteCommandResponse> Handle(StudentDeleteCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.DeleteStudent(request.Id);
		return new StudentDeleteCommandResponse();
	}
}
