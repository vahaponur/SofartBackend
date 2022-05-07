using SofartBackend.DataAccess.EfCore.Concrete.EntityRepositories;
using SofartBackend.DataAccess.EfCore.Contracts;
using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.DataAccess.EfCore.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly SofartDbContext _dbContext;
        public UnitOfWork(SofartDbContext dbContext)
        {
            _dbContext = dbContext;
            Creator = new CreatorRepository(_dbContext);
            Image = new ImageRepository(_dbContext);
            Post = new PostRepository(_dbContext);
            Rank = new RankRepository(_dbContext);
            SocialAccount = new SocialAccountRepository(_dbContext);
            SocialMediaType = new SocialMediaTypeRepository(_dbContext);
            User = new UserRepository(_dbContext);

        }
        public ICreatorRepository Creator { get; private set; }

        public IImageRepository Image { get; private set; }

        public IPostRepository Post { get; private set; }

        public IRankRepository Rank { get; private set; }

        public ISocialAccountRepository SocialAccount { get; private set; }

        public ISocialMediaTypeRepository SocialMediaType { get; private set; }

        public IUserRepository User { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
