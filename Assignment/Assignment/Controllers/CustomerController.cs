using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Core.DomainModels.Customers;
using Assignment.Services.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("CustomerID")]
        public async Task<ActionResult<Customer>> GetCustomerById(int customerId)
        {
            return await customerService.GetCustomerById(customerId);
        }
    }
}