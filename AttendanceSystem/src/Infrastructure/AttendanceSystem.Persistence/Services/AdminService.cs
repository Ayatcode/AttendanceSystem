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
using System.Text;
using System.Threading.Tasks;
namespace AttendanceSystem.Persistence.Services;

public class AdminService : IAdminService
{
	private readonly IStudentRepository _student;
	private readonly ISubjectRepository _subject;
	private readonly ITeacherRepository _teacher;
	private readonly ILessonRepository _lesson;
	private readonly IMapper _mapper;

	public AdminService(
		IStudentRepository student, 
		ISubjectRepository subject, 
		ITeacherRepository teacher, 
		ILessonRepository lesson, 
		IMapper mapper)
	{
		_student = student;
		_subject = subject;
		_teacher = teacher;
		_lesson = lesson;
		_mapper = mapper;
	}

	public async Task CreateLesson(LessonCreateDTO lessonCreateDTO)
	{
		if (lessonCreateDTO == null) throw new ArgumentNullException(nameof(lessonCreateDTO));

		var Result = _mapper.Map<Lesson>(lessonCreateDTO);

		await _lesson.CreateAsync(Result);
		await _lesson.SaveAsync();
	}

	public async Task CreateStudent(StudentCreateDTO studentCreateDTO)
	{
		if (studentCreateDTO == null) throw new ArgumentNullException(nameof(studentCreateDTO));

		var Result = _mapper.Map<Student>(studentCreateDTO);

		await _student.CreateAsync(Result);
		await _student.SaveAsync();
	}

	public async Task CreateSubject(SubjectCreateDTO subjectCreate)
	{
		if (subjectCreate == null) throw new ArgumentNullException(nameof(subjectCreate));

		var Result = _mapper.Map<Subject>(subjectCreate);

		await _subject.CreateAsync(Result);
		await _subject.SaveAsync();
	}

	public async Task CreateTeac(TeacherCreateDTO teacherCreateDTO)
	{
		if (teacherCreateDTO == null) throw new ArgumentNullException(nameof(teacherCreateDTO));

		var Result = _mapper.Map<Teacher>(teacherCreateDTO);

		await _teacher.CreateAsync(Result);
		await _teacher.SaveAsync();
	}

	public async Task DeleteLesson(int LessonId)
	{
		var lesson = await _student.FindByIDAsync(LessonId);
		if (lesson == null) throw new NotFoundException("Not found");
		_student.Delete(lesson);
		await _student.SaveAsync();
	}

	public async Task DeleteStudent(int studentId)
	{
		var student = await _student.FindByIDAsync(studentId);
		if (student == null) throw new NotFoundException("Not found");
		_student.Delete(student);
		await _student.SaveAsync();
	}

	public async Task DeleteSubject(int subjectId)
	{
		var subject = await _subject.FindByIDAsync(subjectId);
		if (subject == null) throw new NotFoundException("Not found");
		_subject.Delete(subject);
		await _subject.SaveAsync();
	}

	public async Task DeleteTeac(int teacId)
	{
		var Teacher = await _teacher.FindByIDAsync(teacId);
		if (Teacher == null) throw new NotFoundException("Not found");
		_teacher.Delete(Teacher);
		await _teacher.SaveAsync();
	}

	public async Task<LessonDTO> GetLessonById(int id)
	{
		var lesson = await _lesson.FindByIDAsync(id);
		if (lesson == null) throw new NotFoundException("Not found");
		var result = _mapper.Map<LessonDTO>(lesson);
		return result;
	}

	public async Task<List<LessonDTO>> GetLessons()
	{
		var Lessons = await _lesson.FindAll().ToListAsync();
		if (Lessons == null) { throw new NotImplementedException(); }
		var Result = _mapper.Map<List<LessonDTO>>(Lessons);
		return Result;
	}

	public async Task<StudentDTO> GetStudentByID(int id)
	{
		var student = await _student.FindByIDAsync(id);
		if (student == null) throw new NotFoundException("Not found");
		var result = _mapper.Map<StudentDTO>(student);
		return result;
	}

	public async Task<List<StudentDTO>> GetStudents()
	{
		var Students = await _student.FindAll().ToListAsync();
		if (Students == null) { throw new NotImplementedException(); }
		var Result = _mapper.Map<List<StudentDTO>>(Students);
		return Result;
	}

	public async Task<SubjectDTO> GetSubjectByID(int id)
	{
		var subject = await _subject.FindByIDAsync(id);
		if (subject == null) throw new NotFoundException("Not found");
		var result = _mapper.Map<SubjectDTO>(subject);
		return result;
	}

	public async Task<List<SubjectDTO>> GetSubjects()
	{
		var Subjects = await _subject.FindAll().ToListAsync();
		if (Subjects == null) { throw new NotImplementedException(); }
		var Result = _mapper.Map<List<SubjectDTO>>(Subjects);
		return Result;
	}

	public async Task<TeacherDTO> GetTeacherByID(int id)
	{
		var teacher = await _teacher.FindByIDAsync(id);
		if (teacher == null) throw new NotFoundException("Not found");
		var result = _mapper.Map<TeacherDTO>(teacher);
		return result;
	}

	public async Task<List<TeacherDTO>> GetTeachers()
	{
		var Teachers = await _teacher.FindAll().ToListAsync();
		if (Teachers == null) { throw new NotImplementedException(); }
		var Result = _mapper.Map<List<TeacherDTO>>(Teachers);
		return Result;
	}

	public async Task UpdateLesson(LessonUpdateDTO lessonUpdateDTO)
	{
		var Lesson = _lesson.FindByCondition(l => l.Id == lessonUpdateDTO.Id);
		if (Lesson == null) throw new NotFoundException("Not found");
		var updated = _mapper.Map<Lesson>(lessonUpdateDTO);
		_lesson.Update(updated);
		await _lesson.SaveAsync();
	}
	public async Task UpdateStudent(StudentUpdateDTO studentUpdateDto)
	{
		var student = _student.FindByCondition(l => l.Id == studentUpdateDto.Id);
		if (student == null) throw new NotFoundException("Not found");
		var updated = _mapper.Map<Student>(studentUpdateDto);
		_student.Update(updated);
		await _student.SaveAsync();
	}

	public async Task UpdateSubject(SubjectUpdateDTO subjectUpdateDTO)
	{
		var subject = _subject.FindByCondition(l => l.Id == subjectUpdateDTO.Id);
		if (subject == null) throw new NotFoundException("Not found");
		var updated = _mapper.Map<Subject>(subjectUpdateDTO);
		_subject.Update(updated);
		await _subject.SaveAsync();
	}

	public async Task UpdateTeac(TeacherUpdateDTO teacherUpdateDto)
	{
		var teacher = _subject.FindByCondition(l => l.Id == teacherUpdateDto.Id);
		if (teacher == null) throw new NotFoundException("Not found");
		var updated = _mapper.Map<Teacher>(teacherUpdateDto);
		_teacher.Update(updated);
		await _teacher.SaveAsync();
	}
}