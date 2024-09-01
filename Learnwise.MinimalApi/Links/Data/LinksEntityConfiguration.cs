using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learnwise.MinimalApi.Links.Data;

internal sealed class LinksEntityConfiguration : IEntityTypeConfiguration<Link>
{
    public void Configure(EntityTypeBuilder<Link> builder)
    {
        builder.ToTable("Links");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Description).IsRequired(false);
        builder.Property(l => l.Url).IsRequired();
    }
}