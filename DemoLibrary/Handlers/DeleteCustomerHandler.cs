using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
    {
        private readonly CustomersContext _context;

        public DeleteCustomerHandler(CustomersContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers
                .Include(x => x.Addresses)
                .Include(x => x.EmailAddresses)
                .Include(x => x.PhoneNumbers)
                .Where(x => x.Id == request.Id)
                .SingleOrDefaultAsync();

            if (customer == null)
                return false;

            _context.Customers.Remove(customer);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
            
        }
    }
}
