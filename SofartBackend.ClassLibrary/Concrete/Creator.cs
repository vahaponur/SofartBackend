using SofartBackend.Entities.Concrete.SocialMedia;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SofartBackend.Entities.Concrete
{
    public class Creator:User
    {
        public HashSet<Post> Posts { get; set; } = new HashSet<Post>();
       
    }
}
