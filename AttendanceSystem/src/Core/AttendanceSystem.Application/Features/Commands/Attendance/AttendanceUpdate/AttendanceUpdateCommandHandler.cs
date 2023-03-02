using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Attendance.AttendanceUpdate;

public class AttendanceUpdateCommandHandler : IRequestHandler<AttendanceUpdateCommandRequest, AttendanceUpdateCommandResponse>
{
	private readonly ITeacherService _teacherService;

	public AttendanceUpdateCommandHandler(ITeacherService teacherService)
	{
		_teacherService = teacherService;
	}

	public async Task<AttendanceUpdateCommandResponse> Handle(AttendanceUpdateCommandRequest request, CancellationToken cancellationToken)
	{
		await _teacherService.UpdateStudentStatus(request.AttendanceUpdateDTO);
		return new();
	}
}
