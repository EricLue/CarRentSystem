using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;

namespace CarRent.ReservationManagement.Application
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();
        List<Reservation> GetReservationById(int id);
        void Add(Reservation reservation);
        void Delete(Reservation reservation);
        void DeleteById(int id);
        void Update(Reservation reservation);
    }
}
