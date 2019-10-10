using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.DomainModels.Transactions
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public StatusTransaction Status { get; set;}

        public static TransactionDTO ToTransactionDTO(Transaction transaction)
        {
            return new TransactionDTO()
            {
                Id = transaction.Id,
                Date = transaction.Date.ToString("dd/MM/yyyy hh:mm"),
                Amount = transaction.Amount,
                Currency = transaction.Currency,
                Status = transaction.Status
            };
        }
    }

    
}
