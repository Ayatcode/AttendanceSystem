using AttendanceSystem.Application.DTOs.Subject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.CreateSubject;

public class CreateSubjectCommandRequest:IRequest<CreateSubjectCommandResponse>
{
	public SubjectCreateDTO SubjectCreateDTO { get; set; }
}
