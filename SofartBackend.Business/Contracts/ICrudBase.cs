using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.Contracts
{
    public interface ICrudBase<T> where T : class, IEntity
    {
        Task Add(T entity);
        Task AddAll(IEnumerable<T> entities);
        Task Delete(T entity);
        Task DeleteAll(IEnumerable<T> entities);
        Task Update(T entity);
        Task<T> GetById(int id);
        Task<ICollection<T>> GetAll();
    }
}
