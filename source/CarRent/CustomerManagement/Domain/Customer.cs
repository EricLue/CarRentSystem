using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CustomerManagement.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Familyname { get; set; }

        [Required]
        public string Street { get; set; }

        public string HouseNumber { get; set; }
    }
}
