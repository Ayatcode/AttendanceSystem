using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Lesson : BaseEntity
{
	
	public string? LessonName { get; set; }

	public DateTime? StartedTime { get; set; }
	public DateTime? EndedTime { get; set; }

	public int TeacherId { get; set; }
	public int SubjectId { get; set; }
	public Teacher? Teacher { get; set; }
	public Subject? Subject { get; set; }
}