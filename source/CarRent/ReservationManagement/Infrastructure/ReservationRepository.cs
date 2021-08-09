using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CarManagement.Infrastructure.Context;
using CarRent.ReservationManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRent.ReservationManagement.Infrastructure
{
    public class ReservationRepository : IRepository<Reservation, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public ReservationRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Reservation> FindEntityById(int id)
        {
            return _carRentDbContext.Reservations.Include(e => e.Car).Include(e => e.Customer).Where(e => e.Id.Equals(id)).ToList();
        }

        public List<Reservation> GetAllEntities()
        {
            return _carRentDbContext.Reservations.Include(e => e.Car).Include(e => e.Customer).ToList();
        }

        public void Insert(Reservation entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Reservation entity)
        {
            Remove(entity);
        }

        public void RemoveById(int id)
        {
            RemoveById(id);
        }

        public void Update(Reservation entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
