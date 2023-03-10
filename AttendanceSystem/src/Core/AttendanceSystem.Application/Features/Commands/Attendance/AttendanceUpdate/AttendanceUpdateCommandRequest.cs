using AttendanceSystem.Application.DTOs.Attendance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Attendance.AttendanceUpdate;

public class AttendanceUpdateCommandRequest:IRequest<AttendanceUpdateCommandResponse>
{
	public AttendanceUpdateDTO AttendanceUpdateDTO { get; set; }
}
