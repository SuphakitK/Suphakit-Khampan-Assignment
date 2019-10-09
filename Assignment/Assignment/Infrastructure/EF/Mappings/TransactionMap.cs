using Assignment.Core.DomainModels.Transactions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF.Mappings
{
    public static class TransactionMap
    {
        public static ModelBuilder MapTransaction(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Transaction>();
            entity.ToTable("Transaction");
            entity.Property(c => c.Id).ValueGeneratedOnAdd();
            entity.Property(c => c.Date);
            entity.Property(c => c.Currency);
            entity.Property(c => c.Amount);
            entity.Property(c => c.CreateDate);
            entity.Property(c => c.UpdateDate);
            entity.Property(c => c.Status);
            return modelBuilder;
        }
    }
}
