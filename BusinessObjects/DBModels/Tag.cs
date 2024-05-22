using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels
{
    public class Tag : Entity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } =string.Empty;
        [Required]
        public CostumeTag CostumeTag { get; set; } = new();

    }
}
