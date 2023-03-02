using AttendanceSystem.Application.DTOs.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Lesson.GetAllLessons;

public class GetAllLessonsQueryResponse
{
	public List<LessonDTO> lessonDTOs { get; set; }
}
