using Assignment.Core.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Services.Customers
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerById(int customerId);
    }
}
