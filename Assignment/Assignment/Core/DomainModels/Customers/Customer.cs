using Assignment.Core.DomainModels.Base;
using Assignment.Core.DomainModels.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.DomainModels.Customers
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
