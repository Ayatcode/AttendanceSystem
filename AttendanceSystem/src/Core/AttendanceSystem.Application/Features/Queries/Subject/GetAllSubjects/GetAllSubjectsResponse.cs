using AttendanceSystem.Application.DTOs.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Subject.GetAllSubjects;

public class GetAllSubjectsResponse
{
	public List<SubjectDTO>? subjectDTOs { get; set; }
}
