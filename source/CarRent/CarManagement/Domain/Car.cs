using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CarManagement.Domain
{
    public class Car
    {
        public Guid Id { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        public CarClass Class { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
