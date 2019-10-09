using Assignment.Core.DomainModels.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF.Seedings
{
    public class TransactionMock
    {
        public static void MockTransaction(AssignmentDbContext assignmentDbContext)
        {
            var customer = assignmentDbContext.Customers.Select(c => c);

            var transaction1OfCustomer1 = new Transaction()
            {
                Currency = "USD",
                Amount = (decimal)39.75,
                Status = StatusTransaction.Success,
                CustomerId = customer.First().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var transaction2OfCustomer1 = new Transaction()
            {
                Currency = "EUR",
                Amount = (decimal)40.17,
                Status = StatusTransaction.Canceled,
                CustomerId = customer.First().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var transaction3OfCustomer1 = new Transaction()
            {
                Currency = "THB",
                Amount = (decimal)150.15,
                Status = StatusTransaction.Failed,
                CustomerId = customer.First().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var transaction1OfCustomer2 = new Transaction()
            {
                Currency = "JYP",
                Amount = (decimal)60,
                Status = StatusTransaction.Success,
                CustomerId = customer.Last().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var transaction2OfCustomer2 = new Transaction()
            {
                Currency = "GBP",
                Amount = (decimal)48.95,
                Status = StatusTransaction.Canceled,
                CustomerId = customer.Last().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var transaction3OfCustomer2 = new Transaction()
            {
                Currency = "CNY",
                Amount = (decimal)7985.07,
                Status = StatusTransaction.Failed,
                CustomerId = customer.Last().Id,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            assignmentDbContext.Add(transaction1OfCustomer1);
            assignmentDbContext.Add(transaction2OfCustomer1);
            assignmentDbContext.Add(transaction3OfCustomer1);
            assignmentDbContext.Add(transaction1OfCustomer2);
            assignmentDbContext.Add(transaction2OfCustomer2);
            assignmentDbContext.Add(transaction3OfCustomer2);

            assignmentDbContext.SaveChanges();

        }

    }
}
