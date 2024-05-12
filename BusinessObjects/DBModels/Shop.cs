using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels;

public class Shop : Entity<Guid>
{
    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description {  get; set; } = string.Empty;

    public string? AvatarUrl { get; set; }

    public ICollection<Costume> Costumes { get; set; } = new List<Costume>();
}
