using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DBModels;

public class Entity<TId> where TId : IEquatable<TId>
{
    [Key]
    public TId Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified {  get; set; }

    [ConcurrencyCheck]
    public long? Version { get; set; }
}
