using DemoLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries
{
    public record GetCustomersQuery : IRequest<IEnumerable<Customer>>;

    //public class GetCustomersQuery : IRequest<IEnumerable<Customer>>
    //{
    //}
}
