using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CarManagement.Model
{
    public class CarDto
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Class { get; set; }
        public decimal DailyPrice { get; set; }

        public CarDto(int id, int classId, string name)
        {
            Id = id;
            ClassId = classId;
            Name = name;
        }
    }
}
