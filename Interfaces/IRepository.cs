using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreRegSite.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T newEntity);
        void SaveChanges();
    }
}
