using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CarRent.Common.Interfaces
{
    public interface IEntity<T>
    {
        [Key]
        T Id { get; set; }
    }
}
