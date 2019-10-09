using Assignment.Infrastructure.Repositories;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.IoC
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<ICustomerRepository>().Use<CustomerRepository>();
        }
    }
}
