using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels
{
    public class CostumeTag : Entity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Costume Costume { get; set; } = new();

        public ICollection<Tag> Tag { get; set; } = [];
    }
}
