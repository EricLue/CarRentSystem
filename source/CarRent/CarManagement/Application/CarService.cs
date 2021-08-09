using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car, Guid> _repository;

        public CarService(IRepository<Car, Guid> repository)
        {
            _repository = repository;
        }

        public void Add(Car car)
        {
            _repository.Insert(car);
        }

        public void Delete(Car car)
        {
            _repository.Remove(car);
        }

        public void DeleteById(int id)
        {
            _repository.RemoveById(id);
        }

        public List<Car> GetAllCars()
        {
            return _repository.GetAllEntities();
        }

        public List<Car> GetCarById(int id)
        {
            return _repository.FindEntityById(id);
        }

        public List<Car> GetCarByType(ClassType type)
        {
            return _repository.GetAllEntities().Where(e => e.Class.Type == type).ToList();
        }

        public void Update(Car car)
        {
            _repository.Update(car);
        }
    }
}
