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
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, bool>
    {
        private readonly CustomersContext _context;

        public UpdateCustomerHandler(CustomersContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            
            var customer = await _context.Customers
                .Include(x => x.Addresses)
                .Include(x => x.EmailAddresses)
                .Include(x => x.PhoneNumbers)
                .Where(x => x.Id == request.Id)
                .SingleOrDefaultAsync();

            if (customer == null)
                return false;

            customer.UpdateInfo(request.FirstName, request.LastName, request.Addresses, request.EmailAddresses,
                request.PhoneNumbers);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
