using AttendanceSystem.Application.DTOs.Teacher;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.UpdateTeacher;

public class TeacherUpdateCommandRequest:IRequest<TeacherUpdateCommandResponse>
{
	public TeacherUpdateDTO TeacherUpdateDTO { get; set; }
}
