using SofartBackend.DataAccess.EfCore.Contracts;
using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using SofartBackend.Entities.Concrete.SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Concrete.EntityRepositories
{
    public class SocialMediaTypeRepository : Repository<SocialMediaType>, ISocialMediaTypeRepository
    {
        public SocialMediaTypeRepository(SofartDbContext dbContext) : base(dbContext)
        {
        }
    }
}
