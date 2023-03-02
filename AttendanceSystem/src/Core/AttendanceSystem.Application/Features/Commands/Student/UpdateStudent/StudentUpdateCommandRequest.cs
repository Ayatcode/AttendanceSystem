using AttendanceSystem.Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.UpdateStudent;

public class StudentUpdateCommandRequest:IRequest<StudentUpdateCommandResponse> 
{
	public StudentUpdateDTO StudentUpdateDTO { get; set; }
}
