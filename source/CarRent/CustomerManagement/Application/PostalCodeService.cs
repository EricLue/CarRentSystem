using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;

namespace CarRent.CustomerManagement.Application
{
    public class PostalCodeService : IPostalCodeService
    {
        private readonly IRepository<PostalCode, Guid> _repository;

        public PostalCodeService(IRepository<PostalCode, Guid> repository)
        {
            _repository = repository;
        }

        public void Add(PostalCode postalCode)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostalCode postalCode)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PostalCode> GetAllCodes()
        {
            throw new NotImplementedException();
        }

        public List<PostalCode> GetCodeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostalCode postalCode)
        {
            throw new NotImplementedException();
        }
    }
}
