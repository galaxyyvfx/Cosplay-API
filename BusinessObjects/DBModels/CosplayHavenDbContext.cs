using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DBModels;

public class CosplayHavenDbContext : DbContext
{
    private static string? GetConnectionStringFromJson()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        return config.GetConnectionString("CosplayHavenDB");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string? connectionString = GetConnectionStringFromJson();
        if (connectionString != null) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Costume> Costumes { get; set; }
}
