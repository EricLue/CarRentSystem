using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;

namespace CarRent.ReservationManagement.Domain
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public ReservationState State { get; set; }

        public int DaysTotal
        {
            get
            {
                if (Start < End)
                {
                    var total = End - Start;
                    return total.Days;
                }
                else
                {
                    return 0;
                }
            }
        }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }

    public enum ReservationState
    {
        Reserved,
        Rented
    }
}
