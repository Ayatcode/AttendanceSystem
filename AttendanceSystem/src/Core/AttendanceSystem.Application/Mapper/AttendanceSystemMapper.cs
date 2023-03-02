using AttendanceSystem.Application.DTOs.Attendance;
using AttendanceSystem.Application.DTOs.Lesson;
using AttendanceSystem.Application.DTOs.Student;
using AttendanceSystem.Application.DTOs.Subject;
using AttendanceSystem.Application.DTOs.Teacher;
using AttendanceSystem.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Mapper;

public class AttendanceMapper : Profile
{
	public AttendanceMapper()
	{
		CreateMap<Student, StudentDTO>().ReverseMap();
		CreateMap<Student, StudentUpdateDTO>().ReverseMap();
		CreateMap<Student, StudentCreateDTO>().ReverseMap();

		CreateMap<Subject, SubjectDTO>().ReverseMap();
		CreateMap<Subject, SubjectCreateDTO>().ReverseMap();
		CreateMap<Subject, SubjectUpdateDTO>().ReverseMap();

		CreateMap<Teacher, TeacherDTO>().ReverseMap();
		CreateMap<Teacher, TeacherCreateDTO>().ReverseMap();
		CreateMap<Teacher, TeacherUpdateDTO>().ReverseMap();

		CreateMap<Lesson, LessonDTO>().ReverseMap();
		CreateMap<Lesson, LessonCreateDTO>().ReverseMap();
		CreateMap<Lesson, LessonUpdateDTO>().ReverseMap();


		CreateMap<Attendance, AttendanceCreateDTO>().ReverseMap();
		CreateMap<Attendance, AttendanceUpdateDTO>().ReverseMap();
	}
}