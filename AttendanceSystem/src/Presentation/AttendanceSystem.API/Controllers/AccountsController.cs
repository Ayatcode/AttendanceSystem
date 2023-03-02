using AttendanceSystem.Application.Features.Commands.Auth.CreateUser;
using AttendanceSystem.Application.Features.Commands.Auth.DeleteUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AttendanceSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
	private readonly IMediator _mediator;

	public AccountsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpPost]
	public async Task<IActionResult> Post([FromForm] CreateUserCommandRequest createUserCommandRequest)
	{
		CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
		return StatusCode((int)HttpStatusCode.Created, response);
	}


	[HttpDelete]
	public async Task<IActionResult> Delete([FromQuery] DeleteUserCommandRequest deleteUserCommandRequest)
	{
		DeleteUserCommandResponse response = await _mediator.Send(deleteUserCommandRequest);
		return StatusCode((int)HttpStatusCode.OK, response);
	}

}