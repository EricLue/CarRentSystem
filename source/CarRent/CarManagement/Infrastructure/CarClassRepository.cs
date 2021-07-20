using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Infrastructure
{
    public class CarClassRepository : IRepository<CarClass, Guid>
    {
        List<CarClass> IRepository<CarClass, Guid>.FindEntityById(Guid id)
        {
            throw new NotImplementedException();
        }

        List<CarClass> IRepository<CarClass, Guid>.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        void IRepository<CarClass, Guid>.Insert(CarClass entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<CarClass, Guid>.Remove(CarClass entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<CarClass, Guid>.RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IRepository<CarClass, Guid>.Update(CarClass entity)
        {
            throw new NotImplementedException();
        }
    }
}
