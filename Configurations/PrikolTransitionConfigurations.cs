using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PrikolTransitionConfiguration : IEntityTypeConfiguration<PrikolTransition>
{
    public void Configure(EntityTypeBuilder<PrikolTransition> builder)
    {
        builder.HasKey(p => p.PrikolTransitionId);

        builder.HasOne(i => i.Prikol)
          .WithMany(j => j.PrikolTransitions)
          .HasForeignKey(p => p.PrikolId);

        builder.HasOne(u => u.User)
          .WithMany(j => j.PrikolTransitions)
          .HasForeignKey(i => i.UserId);

        builder.HasOne(e => e.PreviousTransition)
          .WithOne() 
          .HasForeignKey<PrikolTransition>(e => e.PreviousTransitionId)
          .OnDelete(DeleteBehavior.Restrict);
    }
}

