using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.DTOs.Teacher;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Teacher.GetAllTeachers;

public class GetAllTeachersQueryHandler:IRequestHandler<GetAllTeachersQueryRequest,GetAllTeachersQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetAllTeachersQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetAllTeachersQueryResponse> Handle(GetAllTeachersQueryRequest request, CancellationToken cancellationToken)
	{
		List<TeacherDTO> teacherDTOs = await _adminService.GetTeachers();
		GetAllTeachersQueryResponse response= new GetAllTeachersQueryResponse()
		{
			TeacherDTOs= teacherDTOs,
		};
		return response;
	}
}
