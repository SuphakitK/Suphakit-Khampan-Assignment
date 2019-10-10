using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Assignment.Services.Validations
{
    public class CustomerValidation : ICustomerValidation
    {
        public string ValidationCustomerId(int customerId)
        {
            return customerId <= 0 ? "Invalid Customer ID" : string.Empty;
        }
        public string ValidationCustomerEmail(string customerEmail)
        {
            if (!string.IsNullOrEmpty(customerEmail))
            {
                try
                {
                    var resultEmail = new MailAddress(customerEmail);
                    return string.Empty;
                }
                catch (Exception)
                {
                    return "Invalid Customer Email";
                }
            }

            return "Customer Email is empty";

        }

        public string ValidationCustomerIdAndEmail(int customerId, string customerEmail)
        {
            if (customerId == 0 && string.IsNullOrEmpty(customerEmail))
            {
                return "No inquiry criteria";
            }
            var validationCustomerId = ValidationCustomerId(customerId);

            if (!string.IsNullOrEmpty(validationCustomerId))
            {
                return validationCustomerId;
            }

            var validationCustomerEmail = ValidationCustomerEmail(customerEmail);

            if (!string.IsNullOrEmpty(validationCustomerEmail))
            {
                return validationCustomerEmail;
            }

            return string.Empty;
        }

    }
}
