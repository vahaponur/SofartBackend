using SofartBackend.Entities.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SofartBackend.Entities.Concrete
{
    public class Image : IImage
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Link { get; set; }

        public int Id { get ; set ; }
    }
}
