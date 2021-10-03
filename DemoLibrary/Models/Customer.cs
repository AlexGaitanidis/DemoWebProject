using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public List<Phone> PhoneNumbers { get; set; }

        public void UpdateInfo(string firstName, string lastName, List<Address> addresses, List<Email> emailAddresses,
            List<Phone> phoneNumbers)
        {
            FirstName = firstName;
            LastName = lastName;
            Addresses = addresses;
            EmailAddresses = emailAddresses;
            PhoneNumbers = phoneNumbers;
        }
    }
}
