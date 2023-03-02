using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Attendance.AttendanceCreate;

public class AttendanceCreateCommandHandler : IRequestHandler<AttendanceCreateCommandRequest, AttendanceCreateCommandResponse>
{
	private readonly ITeacherService _teacherService;

	public AttendanceCreateCommandHandler(ITeacherService teacherService)
	{
		_teacherService = teacherService;
	}

	public async Task<AttendanceCreateCommandResponse> Handle(AttendanceCreateCommandRequest request, CancellationToken cancellationToken)
	{
		await _teacherService.CreateStudentStatus(request.AttendanceCreateDTO);
		return new();
	}
}
