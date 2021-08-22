using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Model;
using CarRent.CarManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarClassController : ControllerBase
    {
        private readonly ICarClassService _carClassService;

        public CarClassController(ICarClassService carClassService)
        {
            _carClassService = carClassService;
        }

        // GET: api/<CarClassController>
        [HttpGet]
        public List<CarClassDto> Get()
        {
            var carClass = _carClassService.GetAll();
            return carClass.Select(cl => new CarClassDto()
            {
                Type = cl.Type,
                Id = cl.Id,
                DailyPrice = cl.DailyPrice
            }).ToList();
        }

        // GET api/<CarClassController>/5
        [HttpGet("{id}")]
        public CarClassDto Get(Guid id)
        {
            var carClass = _carClassService.GetById(id);
            if (carClass != null)
            {
                return new CarClassDto()
                {
                    Id = carClass.Id,
                    Type = carClass.Type,
                    DailyPrice = carClass.DailyPrice
                };
            }

            return new CarClassDto();
        }

        // POST api/<CarClassController>
        [HttpPost]
        public void Post([FromBody] CarClassDto carClassDto)
        {
            var carClass = new CarClass()
            {
                Id = carClassDto.Id,
                Type = carClassDto.Type,
                DailyPrice = carClassDto.DailyPrice
            };

            _carClassService.Add(carClass);
        }

        // PUT api/<CarClassController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarClassDto carClassDto)
        {
            var carClass = _carClassService.GetById(id);
            if (carClass != null)
            {
                carClass.Id = carClassDto.Id;
                carClass.Type = carClassDto.Type;
                carClass.DailyPrice = carClassDto.DailyPrice;

                _carClassService.Add(carClass);
            }
        }

        // DELETE api/<CarClassController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var carClass = _carClassService.GetById(id);
            if (carClass != null)
            {
                _carClassService.DeleteById(id);
            }
        }
    }
}
