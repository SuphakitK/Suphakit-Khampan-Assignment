using Assignment.Core.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.EF.Seedings
{
    public class CustomerMock
    {
        public static void MockCustomer(AssignmentDbContext assignmentDbContext)
        {
            var customer1 = new Customer()
            {
                Name = "Customer1",
                Email = "manaosoftware1@inti.com",
                Phone = 71234568,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var customer2 = new Customer()
            {
                Name = "Customer2",
                Email = "manaosoftware2@inti.com",
                Phone = 234567189,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var customer3 = new Customer()
            {
                Name = "Customer3",
                Email = "manaosoftware3@inti.com",
                Phone = 1239874,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            assignmentDbContext.Add(customer1);
            assignmentDbContext.Add(customer2);
            assignmentDbContext.Add(customer3);
            assignmentDbContext.SaveChanges();
        }
    }
}
