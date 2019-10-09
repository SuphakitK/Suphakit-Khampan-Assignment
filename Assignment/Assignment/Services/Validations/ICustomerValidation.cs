using Assignment.Core.DomainModels.Result;
using Assignment.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Services.Validations
{
    public interface ICustomerValidation
    {
        string ValidationCustomerId(int customerId);
        string ValidationCustomerEmail(string customerEmail);
    }
}
