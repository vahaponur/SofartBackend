using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SofartBackend.DataAccess.EfCore.Contracts
{
    public interface IRepository<T> where T:class,IEntity
    {
        void Add(T entity);
        void AddAll(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteAll(IEnumerable<T> entities);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        T GetById(int id);
        ICollection<T> GetAll(Expression<Func<T, bool>>  filter=null);

    }
}
