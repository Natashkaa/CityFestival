using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreRegSite.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T newEntity);
        void Delete(T entity);
        int GetCount();
        void SaveChanges();
    }
}
