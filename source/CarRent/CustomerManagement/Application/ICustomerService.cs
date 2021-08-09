using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        List<Customer> GetCustomerById(int id);
        void Add(Customer customer);
        void Delete(Customer customer);
        void DeleteById(int id);
        void Update(Customer customer);
    }
}
