using AttendanceSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Domain.Entities;

public class AbsenceReason : BaseEntity
{
	public string? Reason { get; set; }
	public bool? IsReasonable { get; set; }

}
