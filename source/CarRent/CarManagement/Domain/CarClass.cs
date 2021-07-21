using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CarManagement.Domain
{
    public class CarClass : IEntity<Guid>
    {
        public Guid Id { get; set; }
        [Required]
        public ClassType Type { get; set; }
        [Required]
        public decimal DailyPrice { get; set; }
    }

    public enum ClassType
    {
        Luxury,
        Medium,
        Basic
    }
}
