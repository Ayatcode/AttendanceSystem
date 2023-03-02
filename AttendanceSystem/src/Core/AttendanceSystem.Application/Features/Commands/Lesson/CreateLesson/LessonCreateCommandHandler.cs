using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.CreateLesson;

public class LessonCreateCommandHandler : IRequestHandler<LessonCreateCommandRequest, LessonCreateCommandResponse>
{
	private readonly IAdminService _adminService;

	public LessonCreateCommandHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<LessonCreateCommandResponse> Handle(LessonCreateCommandRequest request, CancellationToken cancellationToken)
	{
		await _adminService.CreateLesson(request.LessonCreateDTO);
		return new LessonCreateCommandResponse();
	}
}
