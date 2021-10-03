using DemoLibrary.Models;
using MediatR;

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
