using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record CreateCustomerCommand(string FirstName, string LastName, List<Address> Addresses, List<Email> EmailAddresses, List<Phone> PhoneNumbers) : IRequest<Customer>;

    //public class CreateCustomerCommand : IRequest<Customer>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public List<Address> Addresses { get; set; } = new();
    //    public List<Email> EmailAddresses { get; set; } = new();
    //    public List<Phone> PhoneNumbers { get; set; } = new();
    //}
}
