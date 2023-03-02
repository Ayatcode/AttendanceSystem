using AttendanceSystem.Application.DTOs.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Teacher.GetByIdTeacher;

public class GetByIdTeacherQueryResponse
{
	public TeacherDTO? TeacherDTO { get; set; }
}
