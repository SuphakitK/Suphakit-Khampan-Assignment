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
            var customer = await customerRepository.GetCustomerById(customerId);
            if (customer != null)
                customer.Transactions = customer.Transactions.OrderByDescending(c => c.Date).Take(5).ToList();
            return customer;
        }
        public async Task<Customer> GetCustomerByEmail(string customerEmail)
        {
            var customer = await customerRepository.GetCustomerByEmail(customerEmail);
            if (customer != null)
                customer.Transactions = customer.Transactions.OrderByDescending(c => c.Date).Take(5).ToList();
            return customer;
        }
        public async Task<Customer> GetCustomerByIdAndEmail(int customerId, string customerEmail)
        {
            var customer = await customerRepository.GetCustomerByIdAndEmail(customerId, customerEmail);
            if (customer != null)
                customer.Transactions = customer.Transactions.OrderByDescending(c => c.Date).Take(5).ToList();
            return customer;
        }
    }
}
