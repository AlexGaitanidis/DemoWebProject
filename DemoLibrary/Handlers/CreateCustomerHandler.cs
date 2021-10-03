using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly CustomersContext _context;

        public CreateCustomerHandler(CustomersContext context)
        {
            _context = context;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.FirstName, request.LastName, request.Addresses, request.EmailAddresses, request.PhoneNumbers);

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync(cancellationToken);
            return customer;
        }
    }
}
