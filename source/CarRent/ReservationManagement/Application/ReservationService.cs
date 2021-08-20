using CarRent.ReservationManagement.Domain;
using CarRent.ReservationManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.ReservationManagement.Application
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _repository = reservationRepository;
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
            _repository.Remove(id);
        }

        public List<Reservation> GetAll()
        {
            return _repository.GetAllEntities();
        }

        public List<Reservation> GetReservationByCustomerId(Guid id)
        {
            return _repository.FindByCustomerId(id);
        }


        public List<Reservation> GetReservationByCarId(Guid id)
        {
            return _repository.FindByCarId(id);
        }


        public Reservation GetById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(Reservation reservation)
        {
            _repository.Update(reservation);
        }
    }
}
