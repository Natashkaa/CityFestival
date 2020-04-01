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

        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public int GetCount()
        {
            return db.Set<TEntity>().Count();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}