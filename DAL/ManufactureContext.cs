using DAL.Entities.Recipe;
using DAL.Entities.Resource;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class ManufactureContext : DbContext
{
    public ManufactureContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost:8001;Database=manufacture;Username=admin;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // added sequence
        modelBuilder.Entity<ResourceDescription>().Property(b => b.Id).UseIdentityAlwaysColumn();
        modelBuilder.Entity<ResourceItem>().Property(b => b.Id).UseIdentityAlwaysColumn();
        modelBuilder.Entity<Recipe>().Property(b => b.Id).UseIdentityAlwaysColumn();

    }

    DbSet<ResourceDescription> ResourceDescriptions { get; set; }
    DbSet<ResourceItem> ResourceItems { get; set; }
    DbSet<Recipe> Recipes { get; set; }
}