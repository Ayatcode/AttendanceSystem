using AttendanceSystem.Domain.Entities.Common;
using AttendanceSystem.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class Teacher : BaseEntity
{
	
	public string? TeacherName { get; set; }
	public string? TeacherLastName { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Email { get; set; }


	//public string? appUserId { get; set; }
	//public AppUser? appUser { get; set; }
	public ICollection<Lesson>? Lessons { get; set; }
	public ICollection<Teacher_Has_Subject>? Teacher_Has_Subjects { get; set; }
}