using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Lesson.GetAllLessons;

public class GetAllLessonQueryHandler : IRequestHandler<GetAllLessonsQueryRequest, GetAllLessonsQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetAllLessonQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetAllLessonsQueryResponse> Handle(GetAllLessonsQueryRequest request, CancellationToken cancellationToken)
	{
		var LessonDto = await _adminService.GetLessons();

		GetAllLessonsQueryResponse response= new GetAllLessonsQueryResponse() { lessonDTOs= LessonDto };
		return response;
	}
}
