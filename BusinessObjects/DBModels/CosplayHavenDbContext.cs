using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.DBModels;

public class CosplayHavenDbContext : DbContext
{
    #region Private Methods

    private static string? GetConnectionStringFromJson()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        return config.GetConnectionString("CosplayHavenDB");
    }

    private void SetAuditFields()
    {
        var entries = 
            ChangeTracker.Entries().Where(
                e => e.Entity is Entity
                && (e.State == EntityState.Added || e.State == EntityState.Modified)
            );

        foreach (var entry in entries)
        {
            var entity = (Entity) entry.Entity;

            if (entry.State == EntityState.Added)
            {
                entity.Created = DateTime.UtcNow;
            }
            entity.Modified = DateTime.UtcNow;
        }
    }

    #endregion

    #region Public Methods

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string? connectionString = GetConnectionStringFromJson();
        if (connectionString != null) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public override int SaveChanges()
    {
        SetAuditFields();
        return base.SaveChanges();
    }

    #endregion

    #region Sets

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Costume> Costumes { get; set; }

    #endregion
}
