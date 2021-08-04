using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Server.Models
{
    public class CustomersDbContext : DbContext
    {

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
