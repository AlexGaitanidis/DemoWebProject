using DemoLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Commands
{
    //public record UpdateCustomerCommand(int Id, string FirstName, string LastName, List<Address> Addresses, List<Email> EmailAddresses, List<Phone> PhoneNumbers) : IRequest<bool>;

    public class UpdateCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public List<Phone> PhoneNumbers { get; set; }
    }
}
