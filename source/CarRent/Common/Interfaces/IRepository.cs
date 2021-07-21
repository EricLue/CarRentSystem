using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Common.Interfaces
{
    public interface IRepository<T, in TI>
    {
        List<T> FindEntityById(TI id);
        List<T> GetAllEntities();
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveById(Guid id);
    }
}
