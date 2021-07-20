using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.Common.Infrastructure.DbContext;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarRepository : IRepository<Car, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public CarRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }
        List<Car> IRepository<Car, Guid>.FindEntityById(Guid id)
        {
            throw new NotImplementedException();
        }

        List<Car> IRepository<Car, Guid>.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        void IRepository<Car, Guid>.Insert(Car entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Car, Guid>.Remove(Car entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Car, Guid>.RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Car, Guid>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
