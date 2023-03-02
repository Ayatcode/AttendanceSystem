using AttendanceSystem.Application.Repositories;
using AttendanceSystem.Domain.Entities;
using AttendanceSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
	public StudentRepository(AppDbContext context) : base(context)
	{
	}


}
