using AttendanceSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Configurations;

public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
{
	public void Configure(EntityTypeBuilder<Attendance> builder)
	{
		builder.Property(b => b.IsAbsent).IsRequired();
		builder.Property(b => b.IsAttended).IsRequired();
		builder.Property(b => b.StudentId).IsRequired();
		builder.Property(b => b.LessonId).IsRequired();
		builder.Property(b => b.IsLate).IsRequired();
	}
}
