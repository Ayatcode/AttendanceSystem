using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Exceptions;

public class AlreadyRegisteredException : Exception
{
	public AlreadyRegisteredException(string message) : base(message)
	{

	}
}

