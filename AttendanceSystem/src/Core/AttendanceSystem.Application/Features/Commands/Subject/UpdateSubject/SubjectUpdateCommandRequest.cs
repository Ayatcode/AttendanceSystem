using AttendanceSystem.Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.UpdateSubject;

public class SubjectUpdateCommandRequest:IRequest<SubjectUpdateCommandResponse>
{
	public SubjectUpdateDTO SubjectUpdateDTO { get; set; }
}
