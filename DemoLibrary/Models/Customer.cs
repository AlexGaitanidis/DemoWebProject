using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoLibrary.Models
{
    public class Customer
    {
        public int Id { get; protected set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; protected set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; protected set; }
        public List<Address> Addresses { get; protected set; }
        public List<Email> EmailAddresses { get; protected set; }
        public List<Phone> PhoneNumbers { get; protected set; }

        protected Customer()
        {
            Addresses = new List<Address>();
            EmailAddresses = new List<Email>();
            PhoneNumbers = new List<Phone>();
        }

        public Customer(string firstName, string lastName, List<Address> addresses, List<Email> emailAddresses, List<Phone> phoneNumbers) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Addresses = addresses;
            EmailAddresses = emailAddresses;
            PhoneNumbers = phoneNumbers;
        }

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
