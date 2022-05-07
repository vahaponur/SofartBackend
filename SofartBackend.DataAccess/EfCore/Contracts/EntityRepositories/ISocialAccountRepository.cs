using SofartBackend.Entities.Concrete.SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories
{
    public interface ISocialAccountRepository:IRepository<SocialAccount>
    {
    }
}
