using Assignment.Core.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repositories
{
    interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetCustomerById(int customerId);
    }
}
