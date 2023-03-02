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

public class Student : BaseEntity
{
	
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? Phone { get; set; }
	public string? Address { get; set; }

	//public string? appUserId { get; set; }
	//public AppUser? appUser { get; set; }

	public ICollection<Student_Has_Subject>? Student_has_Subjects { get; set; }

}
