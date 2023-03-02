using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Student.GetStudentById;

public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQueryRequest, GetStudentByIdQueryResponse>
{
	private readonly IAdminService _adminService;

	public GetStudentByIdQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetStudentByIdQueryResponse> Handle(GetStudentByIdQueryRequest request, CancellationToken cancellationToken)
	{
		var studentDto= await _adminService.GetStudentByID(request.Id);
		GetStudentByIdQueryResponse response = new GetStudentByIdQueryResponse() { studentDTO = studentDto };
		return response;
	}
}
