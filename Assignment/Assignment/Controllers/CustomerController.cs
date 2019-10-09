using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.DomainModels.Customers;
using Assignment.Core.DomainModels.Result;
using Assignment.Services.Customers;
using Assignment.Services.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;
        private ICustomerValidation customerValidation;
        public CustomerController(ICustomerService customerService, ICustomerValidation customerValidation)
        {
            this.customerService = customerService;
            this.customerValidation = customerValidation;
        }

        [HttpGet("CustomerID")]
        public async Task<ActionResult<Result<CustomerDTO>>> GetCustomerById(int customerId)
        {
            var validationResult = customerValidation.ValidationCustomerId(customerId);
            if (!string.IsNullOrEmpty(validationResult))
            {
                var errorResult = Result<CustomerDTO>.StatusFailed(validationResult);
                return BadRequest(errorResult);
            }
          
            var customer = await customerService.GetCustomerById(customerId);
            if(customer != null)
            {
                var customerDTO = CustomerDTO.ToCustomerDTO(customer);
                var customerResult = Result<CustomerDTO>.StatusComplete(customerDTO);
                return customerResult;
            }

            return NotFound();
        }

        [HttpGet("CustomerEmail")]
        public async Task<ActionResult<Result<CustomerDTO>>> GetCustomerByEmail(string customerEmail)
        {
            var validationResult = customerValidation.ValidationCustomerEmail(customerEmail);
            if (!string.IsNullOrEmpty(validationResult))
            {
                var errorResult = Result<CustomerDTO>.StatusFailed(validationResult);
                return BadRequest(errorResult);
            }

            var customer = await customerService.GetCustomerByEmail(customerEmail);
            if (customer != null)
            {
                var customerDTO = CustomerDTO.ToCustomerDTO(customer);
                var customerResult = Result<CustomerDTO>.StatusComplete(customerDTO);
                return customerResult;
            }

            return NotFound();
        }

        [HttpGet("CustomerIdAndCustomerEmail")]
        public async Task<ActionResult<Result<CustomerDTO>>> GetCustomerByIdAndEmail(int customerId, string customerEmail)
        {
            var validationResult = customerValidation.ValidationCustomerIdAndEmail(customerId, customerEmail);
            if (!string.IsNullOrEmpty(validationResult))
            {
                var errorResult = Result<CustomerDTO>.StatusFailed(validationResult);
                return BadRequest(errorResult);
            }

            var customer = await customerService.GetCustomerByIdAndEmail(customerId, customerEmail);
            if (customer != null)
            {
                var customerDTO = CustomerDTO.ToCustomerDTO(customer);
                var customerResult = Result<CustomerDTO>.StatusComplete(customerDTO);
                return customerResult;
            }

            return NotFound();
        }
    }
}