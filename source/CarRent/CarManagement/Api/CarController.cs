using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Model;
using CarRent.CarManagement.Domain;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly ICarClassService _carClassService;

        public CarController(ICarService carService, ICarClassService carClassService)
        {
            _carService = carService;
            _carClassService = carClassService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public List<CarDto> Get()
        {
            var car = _carService.GetAll();
            return car.Select(car => new CarDto()
            {
                Make = car.Make,
                ClassId = car.ClassId,
                Class = car.Class,
                Id = car.Id,
                Type = car.Type
            }).ToList();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public CarDto Get (Guid id)
        {
            var car = _carService.GetById(id);
            return new CarDto()
            {
                Make = car.Make,
                ClassId = car.ClassId,
                Id = car.Id
            };
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarDto carDto)
        {
            var car = new Car()
            {
                Id = Guid.NewGuid(),
                ClassId = carDto.ClassId,
                Make = carDto.Make,
                Type = carDto.Type,
            };

            car.Class = _carClassService.GetById(carDto.ClassId);
            _carService.Add(car);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDto carDto)
        {
            var car = _carService.GetById(id);
            if (car != null)
            {
                car.Make = carDto.Make;
                car.ClassId = id;
                car.Type = carDto.Type;
                _carService.Update(car);
            }
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _carService.DeleteById(id);
        }
    }
}
