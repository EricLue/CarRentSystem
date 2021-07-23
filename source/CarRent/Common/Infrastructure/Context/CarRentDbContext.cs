using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;
using CarRent.ReservationManagement.Domain;

namespace CarRent.Common.Infrastructure.Context
{
    public class CarRentDbContext : BaseDbContext
    {
        public CarRentDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureModelBinding<Car, Guid>(modelBuilder);
            ConfigureModelBinding<CarClass, Guid>(modelBuilder);
            ConfigureModelBinding<Customer, Guid>(modelBuilder);
            ConfigureModelBinding<PostalCode, Guid>(modelBuilder);
            ConfigureModelBinding<Reservation, Guid>(modelBuilder);
        }
    }
}
