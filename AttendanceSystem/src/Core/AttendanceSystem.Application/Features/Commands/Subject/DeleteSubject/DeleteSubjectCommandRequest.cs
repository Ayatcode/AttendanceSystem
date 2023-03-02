using AttendanceSystem.Application.Features.Commands.Subject.DeleteSubject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Subject.DeleteSubjectl;

public class DeleteSubjectCommandRequest:IRequest<DeleteSubjectCommandResponse>
{
	public int Id { get; set; }
}
