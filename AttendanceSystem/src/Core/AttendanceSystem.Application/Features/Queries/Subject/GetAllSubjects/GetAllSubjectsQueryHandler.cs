using AttendanceSystem.Application.Abstraction.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Subject.GetAllSubjects;

public class GetAllSubjectsQueryHandler : IRequestHandler<GetAllSubjectsQueryRequest, GetAllSubjectsResponse>
{
	private readonly IAdminService _adminService;

	public GetAllSubjectsQueryHandler(IAdminService adminService)
	{
		_adminService = adminService;
	}

	public async Task<GetAllSubjectsResponse> Handle(GetAllSubjectsQueryRequest request, CancellationToken cancellationToken)
	{
		var subjectDTO = await _adminService.GetSubjects();
		GetAllSubjectsResponse response = new GetAllSubjectsResponse() { subjectDTOs = subjectDTO };
		return response;
	}
}
