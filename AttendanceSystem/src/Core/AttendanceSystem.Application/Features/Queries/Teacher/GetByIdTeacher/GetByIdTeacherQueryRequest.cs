using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Teacher.GetByIdTeacher;

public class GetByIdTeacherQueryRequest:IRequest<GetByIdTeacherQueryResponse>
{
	public int Id { get; set; }
}
