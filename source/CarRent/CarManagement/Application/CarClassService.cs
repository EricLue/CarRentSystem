using CarRent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Application
{
    public class CarClassService : ICarClassService
    {
        private readonly IRepository<CarClass, Guid> _repository;

        public CarClassService(IRepository<CarClass, Guid> repository)
        {
            _repository = repository;
        }

        public void Add(CarClass carClass)
        {
            _repository.Insert(carClass);
        }

        public void Delete(CarClass carClass)
        {
            _repository.Remove(carClass);
        }

        public void DeleteById(int id)
        {
            _repository.RemoveById(id);
        }

        public List<CarClass> GetAllClasses()
        {
            return _repository.GetAllEntities();
        }

        public List<CarClass> GetClassById(int id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(CarClass carClass)
        {
            _repository.Update(carClass);
        }
    }
}
