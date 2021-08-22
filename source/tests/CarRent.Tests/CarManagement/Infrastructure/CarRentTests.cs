using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CarRent.CarManagement.Infrastructure;
using CarRent.CarManagement.Domain;

namespace CarRent.Tests.CarManagement.Infrastructure
{
    public class CarRentTests : IClassFixture<DatabaseFixture>
    {
        public CarRentTests(DatabaseFixture fixture) => Fixture = fixture;

        public DatabaseFixture Fixture { get; }

        [Fact]
        public void AddCar_ValidInputs_ShouldAddCar()
        {
            using (var t = Fixture.Connection.BeginTransaction())
            {
                using (var context = Fixture.CreateContext(t))
                {
                    var carClassController = new CarClassRepository(context);
                    var carController = new CarRepository(context);

                    var carClass = carClassController.GetAllEntities().First();
                    var car = new Car()
                    {
                        Id = Guid.NewGuid(),
                        Class = carClass,
                        ClassId = carClass.Id,
                        Make = "VW Eos",
                        Type = "Limousine"
                    };

                    carController.Insert(car);

                    var savedCar = carController.FindEntityById(car.Id);
                    Assert.Equal(car, savedCar);
                }
            }
        }

        [Fact]
        public void RemoveCarByObject_ValidInputs_ShouldBeRemoved()
        {
            using (var t = Fixture.Connection.BeginTransaction())
            {
                using (var context = Fixture.CreateContext(t))
                {
                    var carController = new CarRepository(context);
                    var getFirstCar = carController.GetAllEntities().First();

                    carController.Remove(getFirstCar);

                    var savedCar = carController.FindEntityById(getFirstCar.Id);
                    Assert.Null(savedCar);
                }
            }
        }

        [Fact]
        public void RemoveCarById_validInput_ShouldBeRemoved()
        {
            using (var t = Fixture.Connection.BeginTransaction())
            {
                using (var context = Fixture.CreateContext(t))
                {
                    var carController = new CarRepository(context);

                    var getFirstCar = carController.GetAllEntities().First();

                    carController.Remove(getFirstCar.Id);

                    var savedCar = carController.FindEntityById(getFirstCar.Id);
                    Assert.Null(savedCar);
                }
            }
        }

    }
}
