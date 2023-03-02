using AttendanceSystem.Application.Features.Commands.Attendance.AttendanceCreate;
using AttendanceSystem.Application.Features.Commands.Attendance.AttendanceUpdate;
using AttendanceSystem.Application.Features.Commands.Teacher.CreateTeacher;
using AttendanceSystem.Application.Features.Commands.Teacher.UpdateTeacher;
using AttendanceSystem.Application.Features.Queries.Student.GetAllStudents;
using AttendanceSystem.Application.Features.Queries.Student.GetStudentById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AttendanceSystem.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TeacherController : ControllerBase
	{
		private readonly IMediator _mediator;

		public TeacherController(IMediator mediator)
		{
			_mediator = mediator;
		}


		[HttpGet("GetAllStudents")]
		public async Task<IActionResult> GetAllStudents([FromQuery] GetAllStudentsQueryRequest getAllStudentsQueryRequest)
		{
			GetAllStudentsQueryResponse response = await _mediator.Send(getAllStudentsQueryRequest);
			return StatusCode((int)HttpStatusCode.OK, response.Students);
		}

		[HttpGet("GetStudentById")]
		public async Task<IActionResult> GetStudentById([FromQuery] GetStudentByIdQueryRequest studentByIdQueryRequest)
		{
			GetStudentByIdQueryResponse response = await _mediator.Send(studentByIdQueryRequest);
			return StatusCode((int)HttpStatusCode.OK, response.studentDTO);
		}

		[HttpPost("PostAttendacne")]
		public async Task<IActionResult> PostAttendacne([FromForm] AttendanceCreateCommandRequest attendanceCreateCommandRequest)
		{
			await _mediator.Send(attendanceCreateCommandRequest);
			return StatusCode((int)HttpStatusCode.Created);
		}

		[HttpPut("PutAttendance")]
		public async Task<IActionResult> PutAttendance([FromForm] AttendanceUpdateCommandRequest attendanceUpdateCommandRequest)
		{
			await _mediator.Send(attendanceUpdateCommandRequest);
			return StatusCode((int)HttpStatusCode.OK);
		}

	}
}
