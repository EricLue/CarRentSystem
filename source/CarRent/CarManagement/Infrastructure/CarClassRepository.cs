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
    public class CarClassRepository : ICarClassRepository
    {
        private readonly CarRentDbContext _dbContext;

        public CarClassRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }

        public CarClass FindEntityById(Guid id)
        {
            return _dbContext.CarClasses.Select(cl => cl).Where(cl => cl.Id.Equals(id)).FirstOrDefault();
        }

        public List<CarClass> GetAllEntities()
        {
            return _dbContext.CarClasses.Select(cl => cl).ToList();
        }

        public void Insert(CarClass entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(CarClass entity)
        {
            Remove(entity.Id);
        }

        public void Remove(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.CarClasses.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(CarClass entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
