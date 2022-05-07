using SofartBackend.DataAccess.EfCore.Contracts;
using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SofartBackend.DataAccess.EfCore.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        readonly SofartDbContext dbContext;
        public Repository(SofartDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(T entity)
        {

            dbContext.Set<T>().Add(entity);
        }

        public void AddAll(IEnumerable<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return dbContext.Set<T>().FirstOrDefault(filter);
        }


        public ICollection<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return dbContext.Set<T>().Where(filter).ToHashSet();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
        }
    }
}
