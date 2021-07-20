using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;

namespace CarRent.CarManagement.Domain
{
    public class Car : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public CarClass Class { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
    }
}
