using Microsoft.EntityFrameworkCore;

namespace Learnwise.MinimalApi.Tasks.Data.Database;

internal sealed class TasksPersistence(DbContextOptions<TasksPersistence> options) : DbContext(options)
{
    private const string Schema = "Tasks";
    
    public DbSet<Task> Tasks => Set<Task>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schema);
        modelBuilder.ApplyConfiguration(new TaskEntityConfiguration());

        modelBuilder.Entity<Task>().OwnsMany(t => t.Notes, a =>
        {
            a.ToJson();
        });
        
        modelBuilder.Entity<Task>().OwnsMany(t => t.CodeSnippets, a =>
        {
            a.ToJson();
        });
    }
}