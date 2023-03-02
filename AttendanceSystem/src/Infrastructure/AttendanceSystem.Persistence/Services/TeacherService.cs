using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.DTOs.Attendance;
using AttendanceSystem.Application.DTOs.Student;
using AttendanceSystem.Application.Exceptions;
using AttendanceSystem.Application.Repositories;
using AttendanceSystem.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AttendanceSystem.Persistence.Services;

public class TeacherService : ITeacherService
{
	private readonly IStudentRepository _student;
	private readonly IMapper _mapper;
	private readonly IAttendanceRepository _attendance;


	public TeacherService(IStudentRepository student, IMapper mapper, IAttendanceRepository attendance)
	{
		_student = student;
		_mapper = mapper;
		_attendance = attendance;
	}

	public async Task CreateStudentStatus(AttendanceCreateDTO attendanceCreateDTO)
	{
		if (attendanceCreateDTO == null) throw new ArgumentNullException(nameof(attendanceCreateDTO));

		var Result = _mapper.Map<Attendance>(attendanceCreateDTO);


		await _attendance.CreateAsync(Result);
		await _attendance.SaveAsync();
	}



	public async Task<StudentDTO> GetStudent(int id)
	{
		var student = await _student.FindByIDAsync(id);

		if (student == null)
		{
			throw new NotFoundException("Not Found");
		}
		var result = _mapper.Map<StudentDTO>(student);
		return result;
	}

	public async Task<List<StudentDTO>> GetStudents()
	{
		var student = await _student.FindAll().ToListAsync();

		if (student == null)
		{
			throw new NotFoundException("Not Found");
		}
		var result = _mapper.Map<List<StudentDTO>>(student);
		return result;
	}

	public async Task UpdateStudentStatus(AttendanceUpdateDTO attendanceUpdate)
	{
		var student = _attendance.FindByCondition(d => d.Id == attendanceUpdate.id).FirstOrDefault();
		if (student == null)
		{
			throw new NotFoundException("Not Found");
		}
		var Result = _mapper.Map<Attendance>(attendanceUpdate);


		_attendance.Update(Result);
		await _attendance.SaveAsync();
	}
}
