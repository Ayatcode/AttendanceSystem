using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Exceptions;

public class AuthFailException : Exception
{
	public AuthFailException() : base(message: "Username or password is invalid")
	{

	}

	public AuthFailException(string message) : base(message)
	{

	}
}
