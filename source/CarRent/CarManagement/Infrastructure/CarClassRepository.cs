using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarClassRepository : IRepository<CarClass, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public CarClassRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<CarClass> FindEntityById(int id)
        {
            return _carRentDbContext.CarClasses.Where(e => e.Id.Equals(id)).ToList();
        }

        public List<CarClass> GetAllEntities()
        {
            return _carRentDbContext.CarClasses.ToList();
        }

        public void Insert(CarClass entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(CarClass entity)
        {
            Remove(entity);
            _carRentDbContext.SaveChanges();
        }

        public void RemoveById(int id)
        {
            RemoveById(id);
            _carRentDbContext.SaveChanges();
        }

        public void Update(CarClass entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
