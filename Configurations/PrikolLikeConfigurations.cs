using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PrikolLikeConfiguration : IEntityTypeConfiguration<PrikolLike>
{
    public void Configure(EntityTypeBuilder<PrikolLike> builder)
    {
        builder.HasKey(k => k.PrikolLikeId);

        builder.HasOne(u => u.User)
          .WithMany(k => k.PrikolLikes)
          .HasForeignKey(i => i.UserId);

        builder.HasOne(p => p.Prikol)
          .WithMany(i => i.PrikolLikes)
          .HasForeignKey(k => k.PrikolId);


    }
}

