using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PrikolGenerationTransitionConfiguration : IEntityTypeConfiguration<PrikolGenerationTransition>
{
    public void Configure(EntityTypeBuilder<PrikolGenerationTransition> builder)
    {
        builder.HasKey(p => p.PrikolGenerationTransitionId);

        builder.HasOne(i => i.Prikol)
          .WithMany(j => j.PrikolGenerationTransitions)
          .HasForeignKey(p => p.PrikolId);

        builder.HasOne(u => u.User)
          .WithMany(j => j.PrikolGenerationTransitions)
          .HasForeignKey(i => i.UserId);

        builder.HasOne(e => e.PreviousTransition)
          .WithOne() // no inverse navigation
          .HasForeignKey<PrikolGenerationTransition>(e => e.PreviousTransitionId)
          .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(i =>i.PreviousTransitionId)
          .IsUnique();
    }
}
