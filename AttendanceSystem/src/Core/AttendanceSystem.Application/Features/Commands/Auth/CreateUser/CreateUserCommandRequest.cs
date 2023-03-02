using AttendanceSystem.Application.DTOs.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Auth.CreateUser;

public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
{
	public UserPostDTO UserPostDTO { get; set; }
}
