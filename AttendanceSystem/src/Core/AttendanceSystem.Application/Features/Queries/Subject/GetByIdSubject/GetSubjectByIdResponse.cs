using AttendanceSystem.Application.DTOs.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Subject.GetByIdSubject;

public class GetSubjectByIdResponse
{
	public SubjectDTO subjectDTO { get; set; }
}
