using AttendanceSystem.Application.Features.Queries.Subject.GetAllSubjects;
using AttendanceSystem.Application.Features.Queries.Subject.GetByIdSubject;
using AttendanceSystem.Application.Features.Queries.Teacher.GetAllTeachers;
using AttendanceSystem.Application.Features.Queries.Teacher.GetByIdTeacher;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AttendanceSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
	private readonly IMediator _mediator;

	public StudentController(IMediator mediator)
	{
		_mediator = mediator;
	}


	[HttpGet("GetAllTeachers")]
	public async Task<IActionResult> GetAllTeachers([FromQuery] GetAllTeachersQueryRequest getAllTeachersQueryRequest)
	{
		GetAllTeachersQueryResponse response = await _mediator.Send(getAllTeachersQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.TeacherDTOs);
	}

	[HttpGet("GetAllSubjects")]
	public async Task<IActionResult> GetAllSubjects([FromQuery] GetAllSubjectsQueryRequest getAllSubjectsQuery)
	{
		GetAllSubjectsResponse response = await _mediator.Send(getAllSubjectsQuery);
		return StatusCode((int)HttpStatusCode.OK, response.subjectDTOs);
	}

	[HttpGet("GetTeacherById")]
	public async Task<IActionResult> GetTeacherById([FromQuery] GetByIdTeacherQueryRequest getByIdTeacherQueryRequest)
	{
		GetByIdTeacherQueryResponse response = await _mediator.Send(getByIdTeacherQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.TeacherDTO);
	}

	[HttpGet("GetSubjectById")]
	public async Task<IActionResult> GetSubjectById([FromQuery] GetSubjectByIdRequest getSubjectByIdRequest)
	{
		GetSubjectByIdResponse response = await _mediator.Send(getSubjectByIdRequest);
		return StatusCode((int)HttpStatusCode.OK, response.subjectDTO);
	}
}
