﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Application.Features.Queries.Subject.GetByIdSubject;

public class GetSubjectByIdRequest:IRequest<GetSubjectByIdResponse> 
{
	public int id { get; set; }
}
