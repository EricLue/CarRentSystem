using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CustomerManagement.Domain
{
    public class Customer : IEntity
    {
        public int Id { get; set; }

        public Sex Sex { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Familyname { get; set; }

        [Required]
        public string Street { get; set; }

        public string HouseNumber { get; set; }

        [Required]
        public int PostalCodeId { get; set; }

        [Required]
        public PostalCode PostCode { get; set; }
    }

    public enum Sex
    {
        Divers,
        Female,
        Other,
        Male
    }
}
