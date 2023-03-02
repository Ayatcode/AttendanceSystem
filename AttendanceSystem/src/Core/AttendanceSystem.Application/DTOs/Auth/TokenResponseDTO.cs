using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.DTOs.Auth;

public class TokenResponseDTO
{
	public string? Token { get; set; }
	public string? Username { get; set; }
	public DateTime Expires { get; set; }
	public string? Messages { get; set; }
}
