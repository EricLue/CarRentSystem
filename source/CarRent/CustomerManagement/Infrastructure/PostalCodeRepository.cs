using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Domain;
using CarRent.Common.Infrastructure.Context;

namespace CarRent.CustomerManagement.Infrastructure
{
    public class PostalCodeRepository : IRepository<PostalCode, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public PostalCodeRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<PostalCode> FindEntityById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PostalCode> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public void Insert(PostalCode entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(PostalCode entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostalCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
