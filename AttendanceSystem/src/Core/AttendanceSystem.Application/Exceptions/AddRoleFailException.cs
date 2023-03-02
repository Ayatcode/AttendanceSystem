using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Exceptions;

public class AddRoleFailException : Exception
{
	public AddRoleFailException() : base(message: "")
	{

	}
	public AddRoleFailException(string message) : base(message)
	{

	}
}
