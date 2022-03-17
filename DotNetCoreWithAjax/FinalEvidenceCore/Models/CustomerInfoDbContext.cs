using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.Models
{
   public class CustomerInfoDbContext:DbContext
    {
        public CustomerInfoDbContext(DbContextOptions<CustomerInfoDbContext> option) : base(option)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FinalEvidenceCore.Models.Supplier> Supplier { get; set; }
    }
}
