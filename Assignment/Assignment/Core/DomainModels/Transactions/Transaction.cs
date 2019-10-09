using Assignment.Core.DomainModels.Base;
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

    }

    public enum StatusTransaction
    {
        Success,
        Failed,
        Canceled
    }
}

