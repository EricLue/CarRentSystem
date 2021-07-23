using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.ReservationManagement.Model
{
    public class ReervationDto
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string State { get; set; }
        public int DaysTotal { get; set; }
        public Guid CarId { get; set; }
        public string CarName { get; set; }
        public decimal Cost { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
