using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CarRent.CustomerManagement.Domain
{
    public class PostalCode : IEntity<Guid>
    {
        public Guid Id { get; set; }
        
        [Required]
        public string PostCode { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
