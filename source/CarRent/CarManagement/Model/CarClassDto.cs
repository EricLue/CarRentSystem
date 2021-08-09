using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Model
{
    public class CarClassDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
