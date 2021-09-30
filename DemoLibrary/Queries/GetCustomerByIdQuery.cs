﻿using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetCustomerByIdQuery(int id) : IRequest<Customer>;

    //public class GetCustomerByIdQuery : IRequest<Customer>
    //{
    //    public int Id { get; set; }
    //    public GetCustomerByIdQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
