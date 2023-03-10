using AttendanceSystem.Application.DTOs.Attendance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Commands.Attendance.AttendanceCreate;

public class AttendanceCreateCommandRequest:IRequest<AttendanceCreateCommandResponse>
{
	public AttendanceCreateDTO AttendanceCreateDTO { get; set; }
}
