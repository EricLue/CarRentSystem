using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer, Guid> _repository;

        public CustomerService(IRepository<Customer, Guid> repository)
        {
            _repository = repository;
        }

        public void Add(Customer customer)
        {
            _repository.Insert(customer);
        }

        public void Delete(Customer customer)
        {
            _repository.Remove(customer);
        }

        public void DeleteById(Guid id)
        {
            _repository.RemoveById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllEntities();
        }

        public List<Customer> GetCustomerById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }
    }
}
