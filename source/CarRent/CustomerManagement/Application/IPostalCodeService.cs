using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public interface IPostalCodeService
    {
        List<PostalCode> GetAllCodes();
        List<PostalCode> GetCodeById(int id);
        void Add(PostalCode postalCode);
        void Delete(PostalCode postalCode);
        void DeleteById(int id);
        void Update(PostalCode postalCode);
    }
}
