using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Attendance : BaseEntity
{
	
	public int LessonId { get; set; }
	public Lesson? Lessons { get; set; }

	public int StudentId { get; set; }
	public Student? Student { get; set; }

	public int AbsenceReasonId { get; set; }
	public AbsenceReason? AbsenceReason { get; set; }

	public bool IsLate { get; set; }
	public bool IsAttended { get; set; }

	public bool IsAbsent { get; set; }


}
