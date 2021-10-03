using DemoLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoLibrary.DataAccess
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
        public DbSet<Phone> PhoneNumbers { get; set; }
    }
}
