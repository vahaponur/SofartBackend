using SofartBackend.Business.Contracts;
using SofartBackend.Business.ResponseModels;
using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using SofartBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.Concrete
{
    public class UserManager : IUserService
    {
        readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IResponse> Add(User entity)
        {
            await _userRepository.Add(entity);
            return new SuccessResponse("UserAdded");
        }

        public async Task<IResponse> AddAll(IEnumerable<User> entities)
        {
           await _userRepository.AddAll(entities);
            return new SuccessResponse("Users added");
        }

        public async Task<IResponse> Delete(User entity)
        {
            await _userRepository.Delete(entity);
            return new SuccessResponse("User deleted"); 
        }

        public async Task<IResponse> DeleteAll(IEnumerable<User> entities)
        {
            await _userRepository.DeleteAll(entities);
            return new SuccessResponse("Users deleted");
        }

        public async Task<IDataResponse<ICollection<User>>> GetAll()
        {
            return new SuccessDataResponse<ICollection<User>>(await _userRepository.GetAll());
        }

        public async Task<IDataResponse<User>> GetById(int id)
        {
            return new SuccessDataResponse<User>(await _userRepository.GetById(id));
        }

        public async Task<IResponse> Update(User entity)
        {
            await _userRepository.Update(entity);
            return new SuccessResponse();
        }
    }
}
