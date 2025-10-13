using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.HasKey(r => r.ReportId);

        builder.HasOne(r => r.Prikol)
          .WithMany(b => b.Reports)
          .HasForeignKey(i => i.PrikolId);

        builder.HasOne(u => u.User)
          .WithMany(i => i.Reports)
          .HasForeignKey(y => y.UserId);
    }
}
