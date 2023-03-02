using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Teacher_Has_Subject:BaseEntity
{

	public Subject? Subjects { get; set; }
	public int SubjectId { get; set; }
	public int TeacherId { get; set; }
	public Teacher? Teachers { get; set; }

}
