using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.DTOs.Subject;

public class SubjectUpdateDTO
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? SubjectHours { get; set; }
}
