using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using SofartBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Concrete.EntityRepositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SofartDbContext dbContext) : base(dbContext)
        {
        }
    }
}
