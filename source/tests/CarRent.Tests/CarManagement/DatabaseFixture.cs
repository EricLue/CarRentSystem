using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Infrastructure.Context;
using Microsoft.Data.SqlClient;

namespace CarRent.Tests.CarManagement
{
    public class DatabaseFixture : IDisposable
    {
        private static bool _dbInitialized;
        private static readonly object _inhibit = new object();

        public DatabaseFixture()
        {
            Connection = new SqlConnection(@"Data Source=.; Database=CarRentSystem_XUnit_Tests; Trusted_Connection=True");

            Begin();

            Connection.Open();
        }

        public DbConnection Connection { get; }

        public void Dispose()
        {
            Connection.Dispose();
        }

        private void Begin()
        {
            lock (_inhibit)
            {
                if (!_dbInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                        var carClass = new CarClass()
                        {
                            Id = Guid.NewGuid(),
                            Type= "Luxury",
                            DailyPrice = 250
                        };
                        context.CarClasses.Add(carClass);
                        context.SaveChanges();

                        var car = new Car()
                        {
                            Id = Guid.NewGuid(),
                            ClassId = carClass.Id,
                            Class = carClass,
                            Make = "Lamborghini Huracan",
                            Type = "Sport"
                        };
                        context.Cars.Add(car);
                        context.SaveChanges();
                    }

                    _dbInitialized = true;
                }
            }
        }

        public CarRentDbContext CreateContext(DbTransaction transaction = null)
        {
            var context = new CarRentDbContext(new DbContextOptionsBuilder<CarRentDbContext>().UseSqlServer(Connection).Options);

            if (transaction != null)
            {
                context.Database.UseTransaction(transaction);
            }

            return context;
        }
    }
}
