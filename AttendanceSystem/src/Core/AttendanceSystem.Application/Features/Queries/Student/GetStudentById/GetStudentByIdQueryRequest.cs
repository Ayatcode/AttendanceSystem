using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Student.GetStudentById;

public class GetStudentByIdQueryRequest:IRequest<GetStudentByIdQueryResponse> 
{
	public int Id { get; set; }
}
