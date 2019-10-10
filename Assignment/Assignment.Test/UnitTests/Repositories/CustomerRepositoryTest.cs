using Assignment.Core.DomainModels.Customers;
using System;
using Xunit;
using Moq;
using Assignment.Services.Customers;
using Assignment.Core.DomainModels.Transactions;
using System.Collections.Generic;
using Assignment.Infrastructure.Repositories;
using System.Threading.Tasks;
using System.Linq;

namespace Assignment.Test.UnitTests.Repositories
{
    public class CustomerRepositoryTest
    {
        private readonly ICustomerRepository mockCustomerRepository;
        public CustomerRepositoryTest()
        {
            var allCustomer = new List<Customer>();

            var customer1 = new Customer()
            {
                Id = 1,
                Name = "Tester1",
                Email = "enail@mosyrok.com",
                Phone = 058474789,
                Transactions = new List<Transaction>()
                {
                    new Transaction(), new Transaction(), new Transaction(), new Transaction(), new Transaction()
                }
                
            };

            var customer2 = new Customer()
            {
                Id = 2,
                Name = "Tester2",
                Email = "2Enail@mosyrok.com",
                Phone = 09804789,
                Transactions = new List<Transaction>()

            };

            var customer3 = new Customer()
            {
                Id = 3,
                Name = "Tester3",
                Email = "Tes3enail@mosyrok.com",
                Phone = 058474789,
                Transactions = new List<Transaction>()
                {
                    new Transaction(), new Transaction(), new Transaction()
                }

            };

            allCustomer.Add(customer1);
            allCustomer.Add(customer2);
            allCustomer.Add(customer3);

            Mock<ICustomerRepository> mockCustomerRepository = new Mock<ICustomerRepository>();

            mockCustomerRepository.Setup(c => c.GetCustomerById(It.IsAny<int>())).ReturnsAsync((int customerId) => allCustomer.Where(c => c.Id == customerId).SingleOrDefault());
            mockCustomerRepository.Setup(c => c.GetCustomerByEmail(It.IsAny<string>())).ReturnsAsync((string customerEmail) => allCustomer.Where(c => c.Email == customerEmail).SingleOrDefault());
            mockCustomerRepository.Setup(c => c.GetCustomerByIdAndEmail(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync((int customerId , string customerEmail) =>
                allCustomer.Where(c => c.Id == customerId && c.Email == customerEmail).SingleOrDefault()
            );

            this.mockCustomerRepository = mockCustomerRepository.Object;



        }

        [Fact]

        public async Task GetCustomerById_Should_Success_When_InputCustomerId()
        {
            var customerId = 2;

            var result = await mockCustomerRepository.GetCustomerById(customerId);

            Assert.NotNull(result);
            Assert.True(result.Transactions.Count() == 0);
        }

        [Fact]
        public async Task GetCustomerByEmail_Should_Success_When_InputCustomerEmail()
        {
            var customerEmail = "Tes3enail@mosyrok.com";

            var result = await mockCustomerRepository.GetCustomerByEmail(customerEmail);

            Assert.NotNull(result);
            Assert.True(result.Transactions.Count() == 3);
        }

        [Fact]
        public async Task GetCustomerByIdAndEmail_Should_Success_When_InputCustomerIdAndCustomerEmail()
        {
            var customerId = 1;
            var customerEmail = "enail@mosyrok.com";

            var result = await mockCustomerRepository.GetCustomerByIdAndEmail(customerId, customerEmail);

            Assert.NotNull(result);
            Assert.True(result.Transactions.Count() == 5);
        }
    }
}
