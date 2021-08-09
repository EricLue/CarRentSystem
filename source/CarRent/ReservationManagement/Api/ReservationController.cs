using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Model;
using CarRent.ReservationManagement.Domain;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.ReservationManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReservationService _reservationService;

        public ReservationController(IMapper mapper, IReservationService reservationService)
        {
            _mapper = mapper;
            _reservationService = reservationService;
        }

        // GET: api/<ReservationController>
        [HttpGet]
        public List<ReservationDto> Get()
        {
            return _reservationService.GetAllReservations().Select(reservation => _mapper.Map<ReservationDto>(reservation)).ToList();
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public List<ReservationDto> Get(int id)
        {
            return _reservationService.GetReservationById(id).Select(reservation => _mapper.Map<ReservationDto>(reservation)).ToList();
        }

        // POST api/<ReservationController>
        [HttpPost]
        public void Post([FromBody] ReservationDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);
            _reservationService.Add(reservation);
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReservationDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);
            _reservationService.Update(reservation);

        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reservationService.DeleteById(id);
        }
    }
}
