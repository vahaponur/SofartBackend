using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;
using System;


namespace SofartBackend.DataAccess.EfCore.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
       ICreatorRepository Creator { get; }
        IImageRepository Image { get; }
        IPostRepository Post { get; }
        IRankRepository Rank { get; }
        ISocialAccountRepository SocialAccount { get; }
        ISocialMediaTypeRepository SocialMediaType { get; }
        IUserRepository User { get; }
    }
}
