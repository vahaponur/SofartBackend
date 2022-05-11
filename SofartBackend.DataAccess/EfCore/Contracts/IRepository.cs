using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Contracts
{
    public interface IRepository<T> where T:class,IEntity
    {
        Task Add(T entity);
        Task AddAll(IEnumerable<T> entities);
        Task Delete(T entity);
        Task DeleteAll(IEnumerable<T> entities);
        Task Update(T entity);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<T> GetById(int id);
        Task<ICollection<T>> GetAll(Expression<Func<T, bool>>  filter=null);

    }
}
