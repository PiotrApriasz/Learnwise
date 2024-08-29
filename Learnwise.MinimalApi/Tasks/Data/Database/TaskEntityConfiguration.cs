using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnwise.MinimalApi.Tasks.Data.Database;

internal sealed class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.ToTable("Tasks");
        builder.HasKey(task => task.Id);
        builder.Property(task => task.Completed).IsRequired();
        builder.Property(task => task.Deadline).IsRequired(false);
        builder.Property(task => task.Name).IsRequired();
        builder.Property(task => task.Description).IsRequired(false);
        builder.Property(task => task.CreatedAt).IsRequired();
        builder.Property(task => task.Priority).IsRequired();
    }
}