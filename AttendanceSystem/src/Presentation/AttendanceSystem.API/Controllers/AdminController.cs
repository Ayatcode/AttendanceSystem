using AttendanceSystem.Application.Features.Commands.Lesson.CreateLesson;
using AttendanceSystem.Application.Features.Commands.Lesson.DeleteLesson;
using AttendanceSystem.Application.Features.Commands.Lesson.UpdateLesson;
using AttendanceSystem.Application.Features.Commands.Student.CreateStudent;
using AttendanceSystem.Application.Features.Commands.Student.DeleteStudent;
using AttendanceSystem.Application.Features.Commands.Student.UpdateStudent;
using AttendanceSystem.Application.Features.Commands.Subject.CreateSubject;
using AttendanceSystem.Application.Features.Commands.Subject.DeleteSubjectl;
using AttendanceSystem.Application.Features.Commands.Subject.UpdateSubject;
using AttendanceSystem.Application.Features.Commands.Teacher.CreateTeacher;
using AttendanceSystem.Application.Features.Commands.Teacher.DeleteTeacher;
using AttendanceSystem.Application.Features.Commands.Teacher.UpdateTeacher;
using AttendanceSystem.Application.Features.Queries.Lesson.GetAllLessons;
using AttendanceSystem.Application.Features.Queries.Lesson.GetLessonById;
using AttendanceSystem.Application.Features.Queries.Student.GetAllStudents;
using AttendanceSystem.Application.Features.Queries.Student.GetStudentById;
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
public class AdminController : ControllerBase
{
	private readonly IMediator _mediator;

	public AdminController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet("GetAllTeachers")]
	public async Task<IActionResult> GetAllTeachers([FromQuery] GetAllTeachersQueryRequest getAllTeachersQueryRequest)
	{
		GetAllTeachersQueryResponse response = await _mediator.Send(getAllTeachersQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.TeacherDTOs);
	}

	[HttpGet("GetAllStudents")]
	public async Task<IActionResult> GetAllStudents([FromQuery] GetAllStudentsQueryRequest getAllStudentsQueryRequest)
	{
		GetAllStudentsQueryResponse response = await _mediator.Send(getAllStudentsQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.Students);
	}

	[HttpGet("GetAllSubjects")]
	public async Task<IActionResult> GetAllSubjects([FromQuery] GetAllSubjectsQueryRequest getAllSubjectsQuery)
	{
		GetAllSubjectsResponse response = await _mediator.Send(getAllSubjectsQuery);
		return StatusCode((int)HttpStatusCode.OK, response.subjectDTOs);
	}

	[HttpGet("GetAllLesson")]
	public async Task<IActionResult> GetAllLesson([FromQuery] GetAllLessonsQueryRequest getAllLessonsQueryRequest)
	{
		GetAllLessonsQueryResponse response = await _mediator.Send(getAllLessonsQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.lessonDTOs);
	}

	[HttpGet("GetTeacherById")]
	public async Task<IActionResult> GetTeacherById([FromQuery] GetByIdTeacherQueryRequest getByIdTeacherQueryRequest)
	{
		GetByIdTeacherQueryResponse response = await _mediator.Send(getByIdTeacherQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.TeacherDTO);
	}


	[HttpGet("GetStudentById")]
	public async Task<IActionResult> GetStudentById([FromQuery] GetStudentByIdQueryRequest studentByIdQueryRequest)
	{
		GetStudentByIdQueryResponse response = await _mediator.Send(studentByIdQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.studentDTO);
	}

	[HttpGet("GetSubjectById")]
	public async Task<IActionResult> GetSubjectById([FromQuery] GetSubjectByIdRequest getSubjectByIdRequest)
	{
		GetSubjectByIdResponse response = await _mediator.Send(getSubjectByIdRequest);
		return StatusCode((int)HttpStatusCode.OK, response.subjectDTO);
	}

	[HttpGet("GetLessonById")]
	public async Task<IActionResult> GetLessonById([FromQuery] GetLessonByIdQueryRequest getLessonByIdQueryRequest)
	{
		GetLessonByIdQueryResponse response = await _mediator.Send(getLessonByIdQueryRequest);
		return StatusCode((int)HttpStatusCode.OK, response.lessonDTO);
	}

	[HttpPost("PostTeacher")]
	public async Task<IActionResult> PostTeacher([FromForm] CreateTeacherCommandRequest createTeacherCommandRequest)
	{
		await _mediator.Send(createTeacherCommandRequest);
		return StatusCode((int)HttpStatusCode.Created);
	}

	[HttpPost("PostStudent")]
	public async Task<IActionResult> PostStudent([FromForm] StudentCreateCommandRequest studentCreateCommand)
	{
		await _mediator.Send(studentCreateCommand);
		return StatusCode((int)HttpStatusCode.Created);
	}

	[HttpPost("PostSubject")]
	public async Task<IActionResult> PostSubject([FromForm] CreateSubjectCommandRequest subjectCommandRequest)
	{
		await _mediator.Send(subjectCommandRequest);
		return StatusCode((int)HttpStatusCode.Created);
	}

	[HttpPost("PostLesson")]
	public async Task<IActionResult> PostLesson([FromForm] LessonCreateCommandRequest lessonCreateCommandRequest)
	{
		await _mediator.Send(lessonCreateCommandRequest);
		return StatusCode((int)HttpStatusCode.Created);
	}

	[HttpPut("PutTeacher")]
	public async Task<IActionResult> PutTeacher([FromForm] TeacherUpdateCommandRequest teacherUpdateCommandRequest)
	{
		await _mediator.Send(teacherUpdateCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpPut("PutStudent")]
	public async Task<IActionResult> PutStudent([FromForm] StudentUpdateCommandRequest studentUpdateCommandRequest)
	{
		await _mediator.Send(studentUpdateCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpPut("PutSubject")]
	public async Task<IActionResult> PutSubject([FromForm] SubjectUpdateCommandRequest subjectUpdateCommandRequest)
	{
		await _mediator.Send(subjectUpdateCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpPut("PutLesson")]
	public async Task<IActionResult> PutLesson([FromForm] LessonUpdateCommandRequest lessonUpdateCommandRequest)
	{
		await _mediator.Send(lessonUpdateCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpDelete("DeleteTeacher")]
	public async Task<IActionResult> DeleteTeacher([FromForm] TeacherDeleteCommandRequest teacherDeleteCommandRequest)
	{
		await _mediator.Send(teacherDeleteCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpDelete("DeleteStudent")]
	public async Task<IActionResult> DeleteStudent([FromForm] StudentDeleteCommandRequest studentDeleteCommandRequest)
	{
		await _mediator.Send(studentDeleteCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpDelete("DeleteSubject")]
	public async Task<IActionResult> DeleteSubject([FromForm] DeleteSubjectCommandRequest deleteSubjectCommandRequest)
	{
		await _mediator.Send(deleteSubjectCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}

	[HttpDelete("DeleteLesson")]
	public async Task<IActionResult> DeleteLesson([FromForm] LessonDeleteCommandRequest lessonDeleteCommandRequest)
	{
		await _mediator.Send(lessonDeleteCommandRequest);
		return StatusCode((int)HttpStatusCode.OK);
	}
}

