using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Infrastructure
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        List<Reservation> FindByCustomerId(Guid id);
        List<Reservation> FindByCarId(Guid id);
 
    }
}
