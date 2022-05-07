using Microsoft.EntityFrameworkCore;
using SofartBackend.Entities.Concrete;
using SofartBackend.Entities.Concrete.SocialMedia;

namespace SofartBackend.DataAccess.EfCore.Concrete
{
    public class SofartDbContext:DbContext
    {
        public SofartDbContext(DbContextOptions options):base(options)
        {
        }
     

        public DbSet<User> Users { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<SocialAccount> SocialAccounts { get; set; }
        public DbSet<SocialMediaType> SocialMediaTypes { get; set; }
    }
}
