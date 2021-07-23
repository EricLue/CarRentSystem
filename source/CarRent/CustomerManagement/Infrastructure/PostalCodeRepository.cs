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
            return _carRentDbContext.PostalCodes.Where(e => e.Id.Equals(id)).ToList();
        }

        public List<PostalCode> GetAllEntities()
        {
            return _carRentDbContext.PostalCodes.ToList();
        }

        public void Insert(PostalCode entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(PostalCode entity)
        {
            Remove(entity);
        }

        public void RemoveById(Guid id)
        {
            RemoveById(id);
        }

        public void Update(PostalCode entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
