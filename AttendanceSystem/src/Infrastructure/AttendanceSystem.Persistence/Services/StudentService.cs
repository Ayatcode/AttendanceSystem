using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.DTOs.Lesson;
using AttendanceSystem.Application.DTOs.Student;
using AttendanceSystem.Application.DTOs.Subject;
using AttendanceSystem.Application.DTOs.Teacher;
using AttendanceSystem.Application.Exceptions;
using AttendanceSystem.Application.Repositories;
using AttendanceSystem.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Services;

public class StudentService : IStudentService
{
	private readonly ITeacherRepository _Teacherrepo;
	private readonly ISubjectRepository _subjectrepo;
	private readonly ILessonRepository _LessonRepo;
	private readonly IMapper _mapper;

	public StudentService(ITeacherRepository teacherrepo,
						  ISubjectRepository subjectrepo,
						  IMapper mapper,
						  ILessonRepository lessonRepo)
	{
		_Teacherrepo = teacherrepo;
		_subjectrepo = subjectrepo;
		_mapper = mapper;
		_LessonRepo = lessonRepo;
	}

	public async Task<List<SubjectDTO>> FindAllSubjectsAsync()
	{
		var subjects = await _subjectrepo.FindAll().ToListAsync();
		if (subjects == null) { throw new NotFoundException("Not found"); };
		var result = _mapper.Map<List<SubjectDTO>>(subjects);
		return result;
	}

	public async Task<List<LessonDTO>> FindAllTeachersAsync()
	{
		var Lessons = await _LessonRepo.FindAll().Include(d => d.Teacher).ToListAsync();
		var Subjects = await _LessonRepo.FindAll().Include(d => d.Subject).ToListAsync();
		//var result = _mapper.Map<List<TeacherDTO>>(teachers);
		List<LessonDTO> result = new List<LessonDTO>();
		if (Lessons != null && Lessons.Count > 0)
		{

			//foreach (var teacher in teachers)
			//{
			//	teacherdto teacherdto = new teacherdto()
			//	{
			//		phonenumber = teacher.phonenumber,
			//		teacherlastname = teacher.teacherlastname,
			//		teachername = teacher.teachername,
			//		email = teacher.email,
			//		subject = teacher.teacher_has_subjects.
			//	};
			//}
			for (int i = 0; i < Lessons.Count; i++)
			{
				LessonDTO lessonDTO = new LessonDTO()
				{
					Id = Lessons[i].Id,
					LessonName = Lessons[i].LessonName,
					TeacherId = Lessons[i].Teacher.Id,
					StartedTime = Lessons[i].StartedTime,
					EndedTime = Lessons[i].EndedTime,
					SubjectId = Subjects[i].Subject.Id,
				};
				result.Add(lessonDTO);
			}
		}

		return result;
	}

	public async Task<List<StudentDTO>> FindByConditionAsync(Expression<Func<Student, bool>> expression)
	{
		throw new NotImplementedException();
	}

	public async Task<SubjectDTO> FindByIdSubjectAsync(int id)
	{
		var subject = await _subjectrepo.FindByIDAsync(id);
		var result = _mapper.Map<SubjectDTO>(subject);
		return result;
	}

	public async Task<TeacherDTO> FindByIdTeacherAsync(int id)
	{
		var Teacher = await _Teacherrepo.FindByIDAsync(id);
		var result = _mapper.Map<TeacherDTO>(Teacher);
		return result;
	}
}
