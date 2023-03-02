using AttendanceSystem.Application.DTOs.Teacher;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Teacher.CreateTeacher;

public class CreateTeacherCommandRequest:IRequest<CreateTeacherCommandResponse>
{
	public TeacherCreateDTO  TeacherCreateDTO { get; set;}
}
