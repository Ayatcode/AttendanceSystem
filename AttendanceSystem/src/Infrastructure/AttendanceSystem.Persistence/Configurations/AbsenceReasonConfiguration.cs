using AttendanceSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Configurations;

public class AbsenceReasonConfiguration : IEntityTypeConfiguration<AbsenceReason>
{
	public void Configure(EntityTypeBuilder<AbsenceReason> builder)
	{
		builder.Property(b => b.Reason).IsRequired().HasMaxLength(100);
		builder.Property(b => b.IsReasonable).IsRequired();
	}
}
