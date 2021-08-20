using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Infrastructure.Context;
using CarRent.CarManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly CarRentDbContext _dbContext;

        public CarRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }
        public Car FindEntityById(Guid id)
        {
            return _dbContext.Cars.Include(e => e.Class).Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        public List<Car> GetAllEntities()
        {
            return _dbContext.Cars.Select(e => e).Include(e => e.Class).ToList();
        }

        public void Insert(Car entity)
        {
            _dbContext.Cars.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Car entity)
        {
            Remove(entity.Id);
        }

        public void Remove(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.Cars.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(Car entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
