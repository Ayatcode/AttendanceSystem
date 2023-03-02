using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Teacher.GetByIdTeacher;

public class GetByIdTeacherQueryHandler : IRequestHandler<GetByIdTeacherQueryRequest, GetByIdTeacherQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetByIdTeacherQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetByIdTeacherQueryResponse> Handle(GetByIdTeacherQueryRequest request, CancellationToken cancellationToken)
	{
		var teacherdto= await  _adminService.GetTeacherByID(request.Id);
		GetByIdTeacherQueryResponse response= new GetByIdTeacherQueryResponse()
		{
			TeacherDTO= teacherdto,
		};
		return response;
	}
}
