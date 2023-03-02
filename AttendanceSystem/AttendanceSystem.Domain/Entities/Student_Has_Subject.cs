using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Student_Has_Subject:BaseEntity
{
	

	public int StudentId { get; set; }
	public int SubjectId { get; set; }
	public Student? Student { get; set; }
	public Subject? Subject { get; set; }
}
