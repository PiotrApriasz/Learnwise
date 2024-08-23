using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Roadmaps.Data.Database;

internal sealed class RoadmapsPersistence(DbContextOptions<RoadmapsPersistence> options) : DbContext(options)
{
    private const string Schema = "Roadmaps";
    
    public DbSet<Roadmap> Roadmaps => Set<Roadmap>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schema);
        modelBuilder.ApplyConfiguration(new RoadmapEntityConfiguration());
    }
}