using AttendanceSystem.Application.DTOs.Lesson;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.UpdateLesson;

public class LessonUpdateCommandRequest:IRequest<LessonUpdateCommandResponse>
{
	public LessonUpdateDTO LessonUpdateDTO { get; set; }
}
