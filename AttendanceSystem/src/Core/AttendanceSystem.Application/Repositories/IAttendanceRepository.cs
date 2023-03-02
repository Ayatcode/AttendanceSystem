﻿using AttendanceSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Repositories;

public interface IAttendanceRepository : IRepository<Attendance>
{
}
