using AttendanceSystem.Application.DTOs.Attendance;
using AttendanceSystem.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Abstraction.Services;

public interface ITeacherService
{
	Task<StudentDTO> GetStudent(int id);
	Task<List<StudentDTO>> GetStudents();
	Task UpdateStudentStatus(AttendanceUpdateDTO attendanceUpdate);
	Task CreateStudentStatus(AttendanceCreateDTO attendanceCreateDTO);

}