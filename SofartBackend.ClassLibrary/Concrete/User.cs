using SofartBackend.Entities.Concrete.SocialMedia;
using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SofartBackend.Entities.Concrete
{
    public class User : IPerson
    {
        [Required]
        [MaxLength(80)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(80)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public Rank Rank;

       [Required]
       [MaxLength(30)]
       public string Password { get; set; }

        public Image? Image { get; set; }

        public List<SocialAccount> SocialAccounts { get; set; } = new List<SocialAccount>();

        public int Id { get; set; }

    
    }
}
