using AttendanceSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.DTOs.Attendance;

public class AttendanceUpdateDTO

{
	public int id { get; set; }
	public int LessonId { get; set; }
	public int StudentId { get; set; }

	public int AbsenceReasonId { get; set; }
	public AbsenceReason? AbsenceReason { get; set; }

	public bool IsLate { get; set; }
	public bool IsAttended { get; set; }

	public bool IsAbsent { get; set; }
}
