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
        List<CarClass> GetClassById();
        void Add(CarClass carClass);
        void Delete(CarClass carClass);
        void DeleteById(Guid id);
        void Update(CarClass carClass);
    }
}
