using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Entities.Concrete
{
    public class Post : IPost
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public HashSet<Creator> Creators { get; set; } = new HashSet<Creator>();
        public HashSet<Image> Images { get; set; } = new HashSet<Image>();

        [Required]
        public int ImageId;

 

    }
}
