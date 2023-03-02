using AttendanceSystem.Domain.Entities;
using AttendanceSystem.Domain.Entities.Common;
using AttendanceSystem.Domain.Entities.User;
using AttendanceSystem.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Persistence.Contexts;

public class AppDbContext:IdentityDbContext<AppUser>
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
	{

	}
	public DbSet<Student> Students { get; set; } = null!;
	public DbSet<Teacher> Teachers { get; set; } = null!;
	public DbSet<Student_Has_Subject> Student_Has_Subjects { get; set; } = null!;
	public DbSet<Teacher_Has_Subject> Teacher_Has_Subjects { get; set; } = null!;
	public DbSet<Lesson> Lessons { get; set; } = null!;
	public DbSet<AbsenceReason> AbsenceReasons { get; set; } = null!;
	public DbSet<Attendance> Attendances { get; set; } = null!;
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
		base.OnModelCreating(modelBuilder);
	}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		var datas = ChangeTracker.Entries<BaseEntity>();
		foreach (var entity in datas)
		{
			_ = entity.State switch
			{
				EntityState.Added => entity.Entity.CreatedDate = DateTime.Now,
				EntityState.Modified => entity.Entity.UpdatedDate = DateTime.Now,
				_ => DateTime.Now
			};
		}
		return base.SaveChangesAsync(cancellationToken);
	}
}
