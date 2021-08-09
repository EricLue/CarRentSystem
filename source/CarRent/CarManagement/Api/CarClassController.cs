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
        private readonly IMapper _mapper;
        private readonly ICarClassService _carClassService;

        public CarClassController(IMapper mapper, ICarClassService carClassService)
        {
            _mapper = mapper;
            _carClassService = carClassService;
        }

        // GET: api/<CarClassController>
        [HttpGet]
        public List<CarClassDto> Get()
        {
            return _carClassService.GetAllClasses().Select(carClass => _mapper.Map<CarClassDto>(carClass)).ToList();
        }

        // GET api/<CarClassController>/5
        [HttpGet("{id}")]
        public List<CarClassDto> Get(int id)
        {
            return _carClassService.GetClassById(id).Select(carClass => _mapper.Map<CarClassDto>(carClass)).ToList();
        }

        // POST api/<CarClassController>
        [HttpPost]
        public void Post([FromBody] CarClassDto carClassDto)
        {
            var carClass = _mapper.Map<CarClass>(carClassDto);
            _carClassService.Add(carClass);
        }

        // PUT api/<CarClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CarClassDto carClassDto)
        {
            var carClass = _mapper.Map<CarClass>(carClassDto);
            _carClassService.Update(carClass);
        }

        // DELETE api/<CarClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carClassService.DeleteById(id);
        }
    }
}
