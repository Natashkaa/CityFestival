using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CoreRegSite.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoreRegSite.Abstract
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class
    {
        protected DbContext db;
        public BaseRepository(DbContext db){
            this.db = db;
        }

        public void Add(TEntity newEntity)
        {
            db.Set<TEntity>().Add(newEntity);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}