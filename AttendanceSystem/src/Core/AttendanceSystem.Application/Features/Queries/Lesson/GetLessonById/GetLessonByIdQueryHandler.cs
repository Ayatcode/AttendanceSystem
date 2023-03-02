using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Lesson.GetLessonById;

public class GetLessonByIdQueryHandler : IRequestHandler<GetLessonByIdQueryRequest, GetLessonByIdQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetLessonByIdQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetLessonByIdQueryResponse> Handle(GetLessonByIdQueryRequest request, CancellationToken cancellationToken)
	{
		var Lessondto= await _adminService.GetLessonById(request.Id);
		GetLessonByIdQueryResponse response= new GetLessonByIdQueryResponse() { lessonDTO= Lessondto };
		return response;
	}
}
