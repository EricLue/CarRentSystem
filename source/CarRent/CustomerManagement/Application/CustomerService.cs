using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;
using CarRent.CustomerManagement.Infrastructure;

namespace CarRent.CustomerManagement.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _repository = customerRepository;
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
            _repository.Remove(id);
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAllEntities();
        }

        public Customer GetById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }
    }
}
