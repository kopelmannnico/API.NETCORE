﻿using MediatR;
using Sat.Recruitment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Requests.Queries
{
    public class GetUsersQuery : IRequest<IEnumerable<User>>
    {
        public int? Id { get; set; }

        public GetUsersQuery(int? id)
        {
            Id = id;
        }
    }

}
