using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.DTOs.Teacher;
public class TeacherDTO
{
	public int Id { get; set; }
	public string? TeacherName { get; set; }
	public string? TeacherLastName { get; set; }

	public string? SubjectName { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Email { get; set; }


}
