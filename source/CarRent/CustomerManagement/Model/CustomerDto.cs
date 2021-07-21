using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.CustomerManagement.Model
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Sex { get; set; }

        public string Firstname { get; set; }

        public string Familyname { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public Guid PostalCodeId { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
