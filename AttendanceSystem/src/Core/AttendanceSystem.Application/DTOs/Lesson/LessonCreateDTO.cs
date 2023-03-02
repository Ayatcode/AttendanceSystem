using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.DTOs.Lesson;

public class LessonCreateDTO
{

	public string? LessonName { get; set; }

	public DateTime? StartedTime { get; set; }
	public DateTime? EndedTime { get; set; }

	public int TeacherId { get; set; }
	public int SubjectId { get; set; }
}
