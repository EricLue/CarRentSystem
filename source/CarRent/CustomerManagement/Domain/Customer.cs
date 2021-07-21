using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CustomerManagement.Domain
{
    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public Sex Sex { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Familyname { get; set; }

        [Required]
        public string Street { get; set; }

        public int HouseNumber { get; set; }

        [Required]
        public Guid PostalCodeId { get; set; }

        [Required]
        public PostalCode postCode { get; set; }
    }

    public enum Sex
    {
        Divers,
        Female,
        Other,
        Male
    }
}
