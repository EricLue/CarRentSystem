using CarRent.ReservationManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.ReservationManagement.Application
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation, Guid> _repository;

        public ReservationService(IRepository<Reservation, Guid> repository)
        {
            _repository = repository;
        }

        public void Add(Reservation reservation)
        {
            _repository.Insert(reservation);
        }

        public void Delete(Reservation reservation)
        {
            _repository.Remove(reservation);
        }

        public void DeleteById(Guid id)
        {
            _repository.RemoveById(id);
        }

        public List<Reservation> GetAllReservations()
        {
            return _repository.GetAllEntities();
        }

        public List<Reservation> GetReservationById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(Reservation reservation)
        {
            _repository.Update(reservation);
        }
    }
}
