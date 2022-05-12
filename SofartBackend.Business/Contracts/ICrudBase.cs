using SofartBackend.Business.ResponseModels;
using SofartBackend.Entities.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SofartBackend.Business.Contracts
{
    public interface ICrudBase<T> where T : class, IEntity
    {
        Task<IResponse> Add(T entity);
        Task<IResponse> AddAll(IEnumerable<T> entities);
        Task<IResponse> Delete(T entity);
        Task<IResponse> DeleteAll(IEnumerable<T> entities);
        Task<IResponse> Update(T entity);
        Task<IDataResponse<T>> GetById(int id);
        Task<IDataResponse<ICollection<T>>> GetAll();
    }
}
