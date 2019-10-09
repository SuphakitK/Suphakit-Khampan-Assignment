using Assignment.Core.DomainModels.Customers;
using Assignment.Core.DomainModels.Transactions;
using Assignment.Infrastructure.EF.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF
{
    public class AssignmentDbContext : DbContext
    {
        public AssignmentDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.MapCustomer();
            modelBuilder.MapTransaction();
            base.OnModelCreating(modelBuilder);
        }

    }
}
