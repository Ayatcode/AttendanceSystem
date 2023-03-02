using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.DeleteLesson;

public class LessonDeleteCommandHandler : IRequestHandler<LessonDeleteCommandRequest, LessonDeleteCommandResponse>
{
	private readonly IAdminService _adminService;

	public LessonDeleteCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<LessonDeleteCommandResponse> Handle(LessonDeleteCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.DeleteLesson(request.Id);
		return new LessonDeleteCommandResponse();
	}
}
