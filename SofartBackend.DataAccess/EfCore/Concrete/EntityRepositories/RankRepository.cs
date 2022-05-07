using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using SofartBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Concrete.EntityRepositories
{
    public class RankRepository : Repository<Rank>, IRankRepository
    {
        public RankRepository(SofartDbContext dbContext) : base(dbContext)
        {
        }
    }
}
