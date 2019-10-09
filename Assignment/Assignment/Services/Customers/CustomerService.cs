using Assignment.Core.DomainModels.Customers;
using Assignment.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public async Task<Customer> GetCustomerById(int customerId)
        {
            return await customerRepository.GetCustomerById(customerId);
        }
        public async Task<Customer> GetCustomerByEmail(string customerEmail)
        {
            return await customerRepository.GetCustomerByEmail(customerEmail);
        }
    }
}
