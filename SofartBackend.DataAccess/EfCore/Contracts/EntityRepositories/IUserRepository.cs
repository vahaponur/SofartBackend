using SofartBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories
{
    public interface IUserRepository:IRepository<User>
    {
    }
}
