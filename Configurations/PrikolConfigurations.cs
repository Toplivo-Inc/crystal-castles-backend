using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PrikolConfiguration : IEntityTypeConfiguration<Prikol>
{
    public void Configure(EntityTypeBuilder<Prikol> builder)
    {
        builder.HasKey(p => p.PrikolId);

        builder.HasOne(u => u.User)
        .WithMany(u => u.Prikols)
        .HasForeignKey(p => p.UserId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(g => g.Generator)
          .WithMany(p => p.Prikols)
          .HasForeignKey(u => u.GeneratorId)
          .OnDelete(DeleteBehavior.Restrict);

        //TO-DO fix models if needed and finish with connections
    }
}
