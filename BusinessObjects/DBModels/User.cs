using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels
{
    public class User : Entity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string DisplayName { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; }= string.Empty;

        public string AvatarUrl { get; set; } = string.Empty; 

        public  ICollection<Employee> Employees { get; set; } = [];
    }
}
