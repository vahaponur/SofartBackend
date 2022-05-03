using SofartBackend.Entities.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SofartBackend.Entities.Concrete.SocialMedia
{
    public class SocialMediaType : IEntity
    {
        public int Id { get ; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public string Svg { get; set; }

    }
}
