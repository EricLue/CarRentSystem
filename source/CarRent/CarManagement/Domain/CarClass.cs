using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Domain
{
    public class CarClass : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public ClassType Type { get; set; }
        public decimal DailyPrice { get; set; }
    }

    public enum ClassType
    {
        Luxury,
        Medium,
        Basic
    }
}
