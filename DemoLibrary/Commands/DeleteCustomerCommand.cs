using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public int Id { get; }

        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
