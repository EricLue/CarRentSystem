using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        List<Car> GetCarById();
        List<Car> GetCarByType(ClassType type);
        void Add(Car car);
        void Delete(Car car);
        void DeleteById(Guid id);
        void Update(Car car);

    }
}
