﻿using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdAddressQueryRequest :IRequest<ResultAddressDto>
    {
        public GetByIdAddressQueryRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
