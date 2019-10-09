using Assignment.Core.DomainModels.Customers;
using Assignment.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Services.Customers
{
    public interface ICustomerService : IService<Customer>
    {
        Task<Customer> GetCustomerById(int customerId);
    }
}
