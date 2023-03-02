using AttendanceSystem.Application.Abstraction.Services;
using AttendanceSystem.Application.Abstraction.Token;
using AttendanceSystem.Application.Mapper;
using AttendanceSystem.Application.Repositories;
using AttendanceSystem.Domain.Entities.User;
using AttendanceSystem.Infrastructure.Services.Token;
using AttendanceSystem.Persistence;
using AttendanceSystem.Persistence.Contexts;
using AttendanceSystem.Persistence.Repositories;
using AttendanceSystem.Persistence.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var constr = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>((options) =>
{
	var dbContextOptionsBuilder = options.UseSqlServer(constr);

});

//builder.Services.AddAutoMapper(typeof(AttendanceMapper).Assembly);

builder.Services.AddApplicationServices();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IAdminService, AdminService>();

builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>();
builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenHandler, TokenHandle>();
builder.Services.AddScoped<AttendanceSystemDbContextInitializer>();

//builder.Services.AddPersistenceServices();
builder.Services.AddIdentity<AppUser, IdentityRole>()
	.AddDefaultTokenProviders()
	.AddEntityFrameworkStores<AppDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(o =>
{
	o.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,

		ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
		ValidAudience = builder.Configuration["JwtSettings:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey
		(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecurityKey"])),
	};
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
using (var scope = app.Services.CreateScope())
{
	var initialezer = scope.ServiceProvider.GetRequiredService<AttendanceSystemDbContextInitializer>();
	await initialezer.InitializeAsync();
	await initialezer.RoleSeedAsync();
	await initialezer.UserSeedAsync();

}

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.MapControllers();

app.Run();
