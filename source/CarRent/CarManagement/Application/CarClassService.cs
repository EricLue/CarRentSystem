using CarRent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Infrastructure;

namespace CarRent.CarManagement.Application
{
    public class CarClassService : ICarClassService
    {
        private readonly ICarClassRepository _repository;

        public CarClassService(ICarClassRepository carClassRepository)
        {
            _repository = carClassRepository;
        }

        public void Add(CarClass carClass)
        {
            _repository.Insert(carClass);
        }

        public void Delete(CarClass carClass)
        {
            _repository.Remove(carClass);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public List<CarClass> GetAll()
        {
            return _repository.GetAllEntities();
        }

        public CarClass GetById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(CarClass carClass)
        {
            _repository.Update(carClass);
        }
    }
}
