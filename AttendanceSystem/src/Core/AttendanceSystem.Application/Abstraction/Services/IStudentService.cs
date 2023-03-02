using AttendanceSystem.Application.DTOs.Lesson;
using AttendanceSystem.Application.DTOs.Student;
using AttendanceSystem.Application.DTOs.Subject;
using AttendanceSystem.Application.DTOs.Teacher;
using AttendanceSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Abstraction.Services;

public interface IStudentService
{
	Task<List<SubjectDTO>> FindAllSubjectsAsync();
	Task<List<LessonDTO>> FindAllTeachersAsync();
	Task<TeacherDTO> FindByIdTeacherAsync(int id);
	Task<SubjectDTO> FindByIdSubjectAsync(int id);
}
