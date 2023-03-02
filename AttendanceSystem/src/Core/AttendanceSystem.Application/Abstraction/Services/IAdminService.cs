using AttendanceSystem.Application.DTOs.Lesson;
using AttendanceSystem.Application.DTOs.Student;
using AttendanceSystem.Application.DTOs.Subject;
using AttendanceSystem.Application.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Abstraction.Services;

public interface IAdminService
{
	Task DeleteStudent(int studentId);
	Task DeleteTeac(int teacId);
	Task DeleteSubject(int subjectId);

	Task DeleteLesson(int LessonId);
	Task<List<TeacherDTO>> GetTeachers();
	Task<List<StudentDTO>> GetStudents();
	Task<List<SubjectDTO>> GetSubjects();
	Task<List<LessonDTO>> GetLessons();

	Task<TeacherDTO> GetTeacherByID(int id);
	Task<StudentDTO> GetStudentByID(int id);
	Task<SubjectDTO> GetSubjectByID(int id);
	Task<LessonDTO> GetLessonById(int id);
	Task CreateTeac(TeacherCreateDTO teacherCreateDTO);
	Task UpdateTeac(TeacherUpdateDTO teacherUpdateDto);

	Task CreateStudent(StudentCreateDTO studentCreateDTO);
	Task UpdateStudent(StudentUpdateDTO studentUpdateDto);

	Task CreateSubject(SubjectCreateDTO subjectCreate);
	Task UpdateSubject(SubjectUpdateDTO subjectUpdateDTO);
	Task CreateLesson(LessonCreateDTO lessonCreateDTO);
	Task UpdateLesson(LessonUpdateDTO lessonUpdateDTO);
}
