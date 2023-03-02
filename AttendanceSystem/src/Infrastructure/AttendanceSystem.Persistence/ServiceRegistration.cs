using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.Repositories;
using AttendanceSystem.Domain.Entities;
using AttendanceSystem.Domain.Entities.User;
using AttendanceSystem.Persistence.Contexts;
using AttendanceSystem.Persistence.Repositories;
using AttendanceSystem.Persistence.Services;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceSystem.Application.Mapper;
using AttendanceSystem.Application.Validators.Teacher;
using AttendanceSystem.Application.Features.Queries.Teacher.GetAllTeachers;

namespace AttendanceSystem.Persistence;

public static class ServiceRegistration
{
	
		public static void AddApplicationServices(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(AttendanceMapper).Assembly);

			services.AddMediatR(cfg => {
				cfg.RegisterServicesFromAssembly(typeof(GetAllTeachersQueryRequest).Assembly);
			});

			services.AddFluentValidationAutoValidation();
			services.AddFluentValidationClientsideAdapters();
			services.AddValidatorsFromAssembly(typeof(GetAllTeachersValidator).Assembly);
		}
}