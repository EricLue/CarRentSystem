using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDto
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public CarDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
