using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DBModels;

public class Entity
{
    public DateTime? Created { get; set; }

    public DateTime? Modified {  get; set; }

    [ConcurrencyCheck]
    public long? Version { get; set; }
}
