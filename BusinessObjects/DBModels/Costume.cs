using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DBModels;

public class Costume : Entity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    public Shop Shop { get; set; } = new();
}
