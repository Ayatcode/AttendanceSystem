using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.UpdateLesson;

public class LessonUpdateCommandHandler : IRequestHandler<LessonUpdateCommandRequest, LessonUpdateCommandResponse>
{
	public readonly IAdminService _adminService;

	public LessonUpdateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<LessonUpdateCommandResponse> Handle(LessonUpdateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.UpdateLesson(request.LessonUpdateDTO);
		return new();
	}
}
