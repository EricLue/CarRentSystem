using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Infrastructure
{
    public interface ICustomerRepository : IRepository<Customer>
    {

    }
}
