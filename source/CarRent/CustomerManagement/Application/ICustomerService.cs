using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;
using CarRent.Common.Application;

namespace CarRent.CustomerManagement.Application
{
    public interface ICustomerService : IService<Customer>
    {

    }
}
