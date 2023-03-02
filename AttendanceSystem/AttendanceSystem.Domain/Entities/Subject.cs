using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Subject : BaseEntity
{
	
	public string? Name { get; set; }
	public string? SubjectHours { get; set; }

	public ICollection<Lesson>? Lessons { get; set; }
	public ICollection<Teacher_Has_Subject>? Subjects_Has_Teachers { get; set; }
	public ICollection<Student_Has_Subject>? Subjects_Has_Students { get; set; }
}
