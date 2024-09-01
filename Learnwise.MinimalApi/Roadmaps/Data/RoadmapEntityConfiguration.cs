using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnwise.MinimalApi.Roadmaps.Data;

internal sealed class RoadmapEntityConfiguration : IEntityTypeConfiguration<Roadmap>
{
    public void Configure(EntityTypeBuilder<Roadmap> builder)
    {
        builder.ToTable("Roadmaps");
        builder.HasKey(roadmap => roadmap.Id);
        builder.Property(roadmap => roadmap.RoadmapUrl).IsRequired();
    }
}