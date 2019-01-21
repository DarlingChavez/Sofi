using DC.Sofi.Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DC.Sofi.Dao
{
    public sealed class BaseRepository<T> where T : BaseEntity
    {

        private DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            var query = (from entity in _dbContext.Set<T>() select entity).AsNoTracking().AsQueryable();
            return query;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            var query = (from entity in _dbContext.Set<T>() select entity).Where(predicate).AsNoTracking().AsQueryable();
            return query;
        }

        public void Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public T Get(object key)
        {
            T entity = _dbContext.Set<T>().Find(key);
            return entity;
        }

        public bool SaveChanges()
        {
            bool afected = false;
            int rows = _dbContext.SaveChanges();
            afected = rows > 0;
            return afected;
        }
    }
}
