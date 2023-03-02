using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Student.GetAllStudents;

public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQueryRequest, GetAllStudentsQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetAllStudentsQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetAllStudentsQueryResponse> Handle(GetAllStudentsQueryRequest request, CancellationToken cancellationToken)
	{
		var StudentDTOs = await _adminService.GetStudents();
		GetAllStudentsQueryResponse response = new GetAllStudentsQueryResponse() { Students=StudentDTOs };
		return response;
	}
}
