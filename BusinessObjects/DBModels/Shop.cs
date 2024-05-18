using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DBModels;

public class Shop : Entity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description {  get; set; } = string.Empty;

    public string? AvatarUrl { get; set; }

    public ICollection<Costume> Costumes { get; set; } = [];
}
