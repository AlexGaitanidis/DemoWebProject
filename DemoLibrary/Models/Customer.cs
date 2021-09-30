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
        public List<Address> Addresses { get; set; } = new();
        public List<Email> EmailAddresses { get; set; } = new();
        public List<Phone> PhoneNumbers { get; set; } = new();

    }
}
