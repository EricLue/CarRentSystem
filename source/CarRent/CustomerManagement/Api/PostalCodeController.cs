using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Model;
using CarRent.CustomerManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CustomerManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostalCodeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPostalCodeService _postalCodeService;

        public PostalCodeController(IMapper mapper, IPostalCodeService postalCodeService)
        {
            _mapper = mapper;
            _postalCodeService = postalCodeService;
        }

        // GET: api/<PostalCodeController>
        [HttpGet]
        public List<PostalCodeDto> Get()
        {
            return _postalCodeService.GetAllCodes().Select(postalCode => _mapper.Map<PostalCodeDto>(postalCode)).ToList();
        }

        // GET api/<PostalCodeController>/5
        [HttpGet("{id}")]
        public List<PostalCodeDto> Get(int id)
        {
            return _postalCodeService.GetCodeById(id).Select(postalCode => _mapper.Map<PostalCodeDto>(postalCode)).ToList();
        }

        // POST api/<PostalCodeController>
        [HttpPost]
        public void Post([FromBody] PostalCodeDto postalCodeDto)
        {
            var postalCode = _mapper.Map<PostalCode>(postalCodeDto);
            _postalCodeService.Add(postalCode);
        }

        // PUT api/<PostalCodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PostalCodeDto postalCodeDto)
        {
            var postalCode = _mapper.Map<PostalCode>(postalCodeDto);
            _postalCodeService.Update(postalCode);
        }

        // DELETE api/<PostalCodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _postalCodeService.DeleteById(id);
        }
    }
}
