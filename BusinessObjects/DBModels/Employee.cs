using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DBModels
{
    public class Employee : Entity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Role { get; set; }
        [Required]
        public Shop Shop { get; set; } = new();
        [Required]
        public User User { get; set; } = new();
    }
}
