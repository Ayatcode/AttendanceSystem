using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Student.DeleteStudent;

public class StudentDeleteCommandRequest:IRequest<StudentDeleteCommandResponse>
{
	public int Id { get; set; }
}
