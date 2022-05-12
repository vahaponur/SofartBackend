using Microsoft.Extensions.DependencyInjection;
using SofartBackend.DataAccess.EfCore.Concrete.EntityRepositories;
using SofartBackend.DataAccess.EfCore.Contracts.EntityRepositories;

namespace SofartBackend.DataAccess
{
    public static class DataAccessModule
    {
        public static void Load(IServiceCollection services)
        {
            
            services.AddScoped<ICreatorRepository, CreatorRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IRankRepository, RankRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISocialAccountRepository, SocialAccountRepository>();
            services.AddScoped<ISocialMediaTypeRepository, SocialMediaTypeRepository>();
        }
    }
}
