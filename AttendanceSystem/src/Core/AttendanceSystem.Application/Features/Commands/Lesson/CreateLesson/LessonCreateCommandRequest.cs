using AttendanceSystem.Application.DTOs.Lesson;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.CreateLesson;

public class LessonCreateCommandRequest:IRequest<LessonCreateCommandResponse>
{
	public LessonCreateDTO LessonCreateDTO { get; set; }
}
