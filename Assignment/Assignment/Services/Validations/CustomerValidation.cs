using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Services.Validations
{
    public class CustomerValidation : ICustomerValidation
    {
        public string ValidationCustomerId(int customerId)
        {
            return customerId <= 0 ? "Invalid Customer ID" : string.Empty;
        }
    }
}
