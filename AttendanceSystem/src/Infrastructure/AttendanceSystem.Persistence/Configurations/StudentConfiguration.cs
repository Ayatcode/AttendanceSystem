using AttendanceSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
	public void Configure(EntityTypeBuilder<Student> builder)
	{
		builder.Property(b=>b.FirstName).IsRequired().HasMaxLength(50);
		builder.Property(b=>b.Address).IsRequired().HasMaxLength(50);
		builder.Property(b=>b.Email).IsRequired().HasMaxLength(50);
		
	}
}
