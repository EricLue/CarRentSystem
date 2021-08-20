using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;
using CarRent.CarManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CarRentDbContext _dbContext;

        public CustomerRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }

        public Customer FindEntityById(Guid id)
        {
            return _dbContext.Customers.Select(ct => ct).Where(ct => ct.Id.Equals(id)).FirstOrDefault();
        }

        public List<Customer> GetAllEntities()
        {
            return _dbContext.Customers.Select(ct => ct).ToList();
        }

        public void Insert(Customer entity)
        {
            _dbContext.Customers.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Customer entity)
        {
            Remove(entity.Id);
        }

        public void Remove(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.Customers.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(Customer entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
