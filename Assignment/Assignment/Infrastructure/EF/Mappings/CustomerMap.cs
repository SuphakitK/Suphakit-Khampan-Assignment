using Assignment.Core.DomainModels.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF.Mappings
{
    public static class CustomerMap
    {
        public static ModelBuilder MapCustomer(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Customer>();
            entity.ToTable("Customer");
            entity.Property(c => c.Id).ValueGeneratedOnAdd();
            entity.Property(c => c.Name);
            entity.Property(c => c.Email);
            entity.Property(c => c.Phone);
            entity.Property(c => c.CreateDate);
            entity.Property(c => c.UpdateDate);
            entity.HasMany(c => c.Transactions).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerId);
            return modelBuilder;
        }
    }
}
