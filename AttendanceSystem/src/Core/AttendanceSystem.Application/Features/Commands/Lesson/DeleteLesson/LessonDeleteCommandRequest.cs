using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Lesson.DeleteLesson;

public class LessonDeleteCommandRequest:IRequest<LessonDeleteCommandResponse>
{
	public int Id { get; set; }
}
