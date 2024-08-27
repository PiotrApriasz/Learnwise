using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Links.Data.Database;

internal sealed class LinksPersistence(DbContextOptions<LinksPersistence> options) : DbContext(options)
{
    private const string Schema = "Links";
    
    public DbSet<Link> Tasks => Set<Link>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schema);
        modelBuilder.ApplyConfiguration(new LinksEntityConfiguration());
    }
}