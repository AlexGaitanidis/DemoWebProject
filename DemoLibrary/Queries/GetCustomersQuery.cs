using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetCustomersQuery : IRequest<IEnumerable<Customer>>;

    //public class GetCustomersQuery : IRequest<IEnumerable<Customer>>
    //{
    //}
}
