using AttendanceSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
	public void Configure(EntityTypeBuilder<Teacher> builder)
	{
		builder.Property(b=>b.PhoneNumber).IsRequired().HasMaxLength(50);
		builder.Property(b=>b.Email).IsRequired().HasMaxLength(50);
		builder.Property(b=>b.TeacherName).IsRequired().HasMaxLength(50);
	}
}
