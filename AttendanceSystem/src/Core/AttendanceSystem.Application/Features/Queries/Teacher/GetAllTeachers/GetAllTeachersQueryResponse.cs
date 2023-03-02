using AttendanceSystem.Application.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Teacher.GetAllTeachers;

public class GetAllTeachersQueryResponse
{
	public List<TeacherDTO>? TeacherDTOs { get; set; }
}
