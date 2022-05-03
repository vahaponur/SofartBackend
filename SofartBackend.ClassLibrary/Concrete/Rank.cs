using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Entities.Concrete
{
    public class Rank:IEntity
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
