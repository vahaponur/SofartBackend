using SofartBackend.Entities.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SofartBackend.Entities.Concrete.SocialMedia
{
    public class SocialAccount : IEntity
    {
        public int Id { get; set; }

        public SocialMediaType SocialMediaType { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public int SocialMediaTypeId { get; set; }
        [Required]
        public string Link { get; set; }

    }
}
