using Assignment.Core.DomainModels.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.DomainModels.Customers
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public List<TransactionDTO> Transactions { get; set; }

        public static CustomerDTO ToCustomerDTO(Customer customer)
        {
            var transactions = new List<TransactionDTO>();
            transactions.AddRange(customer.Transactions.Select(x => TransactionDTO.ToTransactionDTO(x)));

            return new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Transactions = transactions
            };
        }
    }
}
