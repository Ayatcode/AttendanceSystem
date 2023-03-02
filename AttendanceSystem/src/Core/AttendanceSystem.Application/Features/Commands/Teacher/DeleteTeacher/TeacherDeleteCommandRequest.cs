using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.DeleteTeacher;

public class TeacherDeleteCommandRequest:IRequest<TeacherDeleteCommandResponse>
{
	public int Id { get; set; }
}
