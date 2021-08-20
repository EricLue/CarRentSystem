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
    public class Reservation
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public string State { get; set; }

        //public int DaysTotal
        //{
        //    get
        //    {
        //        if (Start < End)
        //        {
        //            var total = End - Start;
        //            return total.Days;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}

        [Required]
        public Guid CarId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }
    }

    public enum ReservationState
    {
        Reserved,
        Rented
    }
}
