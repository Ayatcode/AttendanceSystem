using AttendanceSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Configurations;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
	public void Configure(EntityTypeBuilder<Lesson> builder)
	{
		builder.Property(b => b.StartedTime).IsRequired();
		builder.Property(b => b.EndedTime).IsRequired();
		builder.Property(b => b.SubjectId).IsRequired();
		builder.Property(b => b.TeacherId).IsRequired();

	}
}
