using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Subject.GetByIdSubject;

public class GetSubjectByIdQueryHandler : IRequestHandler<GetSubjectByIdRequest, GetSubjectByIdResponse>
{
	private readonly IAdminService _adminService;

	public GetSubjectByIdQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetSubjectByIdResponse> Handle(GetSubjectByIdRequest request, CancellationToken cancellationToken)
	{
		var subjectdto = await _adminService.GetSubjectByID(request.id);
		GetSubjectByIdResponse response= new GetSubjectByIdResponse() { subjectDTO= subjectdto };
		return response;
	}
}
