using System.Reflection;
using Learnwise.MinimalApi.Links.Data;
using Learnwise.MinimalApi.Roadmaps.Data;
using Microsoft.EntityFrameworkCore;
using Task = Learnwise.MinimalApi.Tasks.Data.Task;

namespace Learnwise.MinimalApi.Database;

internal sealed class LearnwisePersistence(DbContextOptions<LearnwisePersistence> options) : DbContext(options)
{
    public DbSet<Roadmap> Roadmaps => Set<Roadmap>();
    public DbSet<Task> Tasks => Set<Task>();
    public DbSet<Link> Links => Set<Link>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Notes and CodeSnippets are intended to use as a complex type but for now there is no support for
        // collection complex types so it is temporary implemented as owned types with mapping to json
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