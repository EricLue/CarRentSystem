using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;
using CarRent.Common.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class CustomerRepository : IRepository<Customer, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public CustomerRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Customer> FindEntityById(Guid id)
        {
            return _carRentDbContext.Customers.Include(e => e.PostCode).Where(e => e.Id.Equals(id)).ToList();
        }

        public List<Customer> GetAllEntities()
        {
            return _carRentDbContext.Customers.ToList();
        }

        public void Insert(Customer entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Customer entity)
        {
            Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            RemoveById(id);
        }

        public void Update(Customer entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
