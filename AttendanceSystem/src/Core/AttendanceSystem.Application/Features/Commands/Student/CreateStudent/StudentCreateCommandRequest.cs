using AttendanceSystem.Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.CreateStudent;

public class StudentCreateCommandRequest:IRequest<StudentCreateCommandResponse>
{
	public StudentCreateDTO StudentCreateDTO { get; set; }
}
