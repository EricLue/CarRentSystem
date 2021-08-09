using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Application
{
    public interface ICarClassService
    {
        List<CarClass> GetAllClasses();
        List<CarClass> GetClassById(int id);
        void Add(CarClass carClass);
        void Delete(CarClass carClass);
        void DeleteById(int id);
        void Update(CarClass carClass);
    }
}
