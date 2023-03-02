using AttendanceSystem.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Student.GetStudentById;

public class GetStudentByIdQueryResponse
{
	public StudentDTO studentDTO { get; set; }
}
