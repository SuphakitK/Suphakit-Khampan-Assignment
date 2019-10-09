using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.DomainModels.Customers;
using Assignment.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AssignmentDbContext assignmentDbContext;
        public CustomerRepository(AssignmentDbContext assignmentDbContext)
        {
            this.assignmentDbContext = assignmentDbContext;
        }

        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await assignmentDbContext.Customers.Include(c => c.Transactions).SingleOrDefaultAsync(c => c.Id == customerId);
        }
        public async Task<Customer> GetCustomerByEmail(string customerEmail)
        {
            return await assignmentDbContext.Customers.Include(c => c.Transactions).SingleOrDefaultAsync(c => c.Email == customerEmail);
        }

        public async Task<Customer> GetCustomerByIdAndEmail(int customerId, string customerEmail)
        {
            return await assignmentDbContext.Customers.Include(c => c.Transactions).SingleOrDefaultAsync(c => c.Id == customerId && c.Email == customerEmail);
        }
    }
}
