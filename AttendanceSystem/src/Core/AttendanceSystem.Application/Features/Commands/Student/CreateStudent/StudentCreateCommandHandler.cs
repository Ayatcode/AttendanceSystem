using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.CreateStudent;

public class StudentCreateCommandHandler : IRequestHandler<StudentCreateCommandRequest, StudentCreateCommandResponse>
{
	private readonly IAdminService _adminService;

	public StudentCreateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<StudentCreateCommandResponse> Handle(StudentCreateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.CreateStudent(request.StudentCreateDTO);
		return new StudentCreateCommandResponse();
	}
}
