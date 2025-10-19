using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GeneratorConfiguration : IEntityTypeConfiguration<Generator>
{
    public void Configure(EntityTypeBuilder<Generator> builder)
    {
        builder.HasIndex(i => i.Key)
          .IsUnique();
    }
}
