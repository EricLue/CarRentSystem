using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;
using CarRent.Common.Application;

namespace CarRent.ReservationManagement.Application
{
    public interface IReservationService : IService<Reservation>
    {
        List<Reservation> GetReservationByCarId(Guid id);

        List<Reservation> GetReservationByCustomerId(Guid id);
    }
}
