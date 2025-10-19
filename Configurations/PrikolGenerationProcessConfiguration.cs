using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


public class PrikolGenerationProcessConfiguration : IEntityTypeConfiguration<PrikolGenerationProcess>
{
    public void Configure(EntityTypeBuilder<PrikolGenerationProcess> builder)
    {
        builder.HasKey(p => p.PrikolId);
   
        builder.HasOne(p => p.Prikol)
               .WithOne(p => p.PrikolGenerationProcess)
               .HasForeignKey<PrikolGenerationProcess>(p => p.PrikolId)
               .OnDelete(DeleteBehavior.Cascade);
        
    }
}
