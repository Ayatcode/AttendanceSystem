using AttendanceSystem.Application.DTOs.Auth;
using AttendanceSystem.Domain.Entities.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Mapper;

public class AuthMapper : Profile
{
	public AuthMapper()
	{
		CreateMap<AppUser, UserPostDTO>().ReverseMap();
	}
}
