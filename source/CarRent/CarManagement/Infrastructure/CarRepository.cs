﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.Common.Infrastructure.Context;
using CarRent.CarManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarRepository : IRepository<Car, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public CarRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }
        public List<Car> FindEntityById(Guid id)
        {
            return _carRentDbContext.Cars.Include(e => e.Class).Where(e => e.Id.Equals(id)).ToList();
        }

        public List<Car> GetAllEntities()
        {
            return _carRentDbContext.Cars.ToList();
        }

        public void Insert(Car entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Car entity)
        {
            Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            RemoveById(id);
        }

        public void Update(Car entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
