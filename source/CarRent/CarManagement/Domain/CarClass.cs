using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CarManagement.Domain
{
    public class CarClass
    {
        public Guid Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal DailyPrice { get; set; }
    }
}
