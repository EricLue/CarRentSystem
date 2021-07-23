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
            _repository.Insert(postalCode);
        }

        public void Delete(PostalCode postalCode)
        {
            _repository.Remove(postalCode);
        }

        public void DeleteById(Guid id)
        {
            _repository.RemoveById(id);
        }

        public List<PostalCode> GetAllCodes()
        {
            return _repository.GetAllEntities();
        }

        public List<PostalCode> GetCodeById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(PostalCode postalCode)
        {
            _repository.Update(postalCode);
        }
    }
}
