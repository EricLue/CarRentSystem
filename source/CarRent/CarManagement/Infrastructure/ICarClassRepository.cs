using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Infrastructure
{
    public interface ICarClassRepository : IRepository<CarClass>
    {

    }
}
