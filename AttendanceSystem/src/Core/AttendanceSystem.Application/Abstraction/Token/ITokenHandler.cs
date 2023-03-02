using AttendanceSystem.Application.DTOs.Auth;
using AttendanceSystem.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Abstraction.Token;

public interface ITokenHandler
{
	Task<TokenResponseDTO> GenerateTokenAsync(AppUser user);
}