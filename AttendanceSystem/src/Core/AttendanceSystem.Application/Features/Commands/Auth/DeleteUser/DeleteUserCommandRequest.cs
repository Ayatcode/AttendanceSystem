using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.DeleteUser;

public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
{
	public string? IdStr { get; set; }
}

