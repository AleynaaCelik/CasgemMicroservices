﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class UpdateOrderDetailCommandRequest:IRequest
    {
        public int OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public string OrderingID { get; set; }
       
    }
}