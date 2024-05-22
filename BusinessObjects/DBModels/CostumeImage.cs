using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels
{
    public class CostumeImage : Entity
    {
        [Required]
        public Guid Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public Costume Costume { get; set; } = new();
    }
}
