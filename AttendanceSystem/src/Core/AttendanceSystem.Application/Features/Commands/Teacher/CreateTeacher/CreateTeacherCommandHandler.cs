using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.CreateTeacher;

public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommandRequest, CreateTeacherCommandResponse>
{
	private readonly IAdminService _adminService;

	public CreateTeacherCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<CreateTeacherCommandResponse> Handle(CreateTeacherCommandRequest request, CancellationToken cancellationToken)
	{
		 await _adminService.CreateTeac(request.TeacherCreateDTO);
		return new();
	}
}
