using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Model;
using CarRent.CustomerManagement.Domain;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CustomerManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerController(IMapper mapper, ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDto> Get()
        {
            return _customerService.GetAllCustomers().Select(customer => _mapper.Map<CustomerDto>(customer)).ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public List<CustomerDto> Get(int id)
        {
            return _customerService.GetCustomerById(id).Select(customer => _mapper.Map<CustomerDto>(customer)).ToList();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.Add(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.Update(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.DeleteById(id);
        }
    }
}
