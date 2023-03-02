using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Lesson.GetLessonById;

public class GetLessonByIdQueryRequest:IRequest<GetLessonByIdQueryResponse>
{
	public int Id { get; set; }
}
