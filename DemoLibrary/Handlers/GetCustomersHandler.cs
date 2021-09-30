using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetCustomersHandler : IRequestHandler<GetCustomersQuery, IEnumerable<Customer>>
    {
        private readonly CustomersContext _context;

        public GetCustomersHandler(CustomersContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _context.Customers
                .Include(x => x.Addresses)
                .Include(x => x.EmailAddresses)
                .Include(x => x.PhoneNumbers)
                .ToListAsync();

            return customers;
        }
    }
}
