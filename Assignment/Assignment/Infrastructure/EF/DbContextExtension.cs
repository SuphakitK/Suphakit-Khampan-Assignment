using Assignment.Infrastructure.EF.Seedings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF
{
    public static class DbContextExtension
    {
        public static void SeedingsData(this AssignmentDbContext assignmentDbContext)
        {
            if(!assignmentDbContext.Customers.Any() || !assignmentDbContext.Transactions.Any())
            {
                CustomerMock.MockCustomer(assignmentDbContext);
                TransactionMock.MockTransaction(assignmentDbContext);
            }
        }
    }
}
