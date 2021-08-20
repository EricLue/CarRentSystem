using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Infrastructure;

namespace CarRent.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository carRepository)
        {
            _repository = carRepository;
        }

        public void Add(Car car)
        {
            _repository.Insert(car);
        }

        public void Delete(Car car)
        {
            _repository.Remove(car);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public List<Car> GetAll()
        {
            return _repository.GetAllEntities();
        }


        public Car GetById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public List<Car> GetCarByType(CarClass type)
        {
            return _repository.GetAllEntities().Where(c => c.ClassId.Equals(type.Id)).ToList();
        }

        public void Update(Car car)
        {
            _repository.Update(car);
        }
    }
}
