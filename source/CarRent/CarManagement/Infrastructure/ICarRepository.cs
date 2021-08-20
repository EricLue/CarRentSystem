using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Domain;

namespace CarRent.CarManagement.Infrastructure
{
    public interface ICarRepository : IRepository<Car>
    {
    }
}
