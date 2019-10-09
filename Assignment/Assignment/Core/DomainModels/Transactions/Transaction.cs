using Assignment.Core.DomainModels.Base;
using Assignment.Core.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.DomainModels.Transactions
{
    public class Transaction : EntityBase
    {
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public StatusTransaction Status { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }

    public enum StatusTransaction
    {
        Success,
        Failed,
        Canceled
    }
}

