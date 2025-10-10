using Microsoft.EntityFrameworkCore;
using CrystalCastlesBackend.Models;

public class CastlesDbContext : DbContext
{
    public CastlesDbContext(DbContextOptions<CastlesDbContext> options)
      : base(options)
    {


    }

    public required DbSet<Generator> Generators { get; set; }
    public required DbSet<Prikol> Prikols { get; set; }
    public required DbSet<PrikolGenerationProcess> PrikolGenerationProcesses { get; set; }
    public required DbSet<Report> Reports { get; set; }
    public required DbSet<User> Users { get; set; }
    public required DbSet<PrikolGenerationTransition> PrikolGenerationTransition { get; set; }
    public required DbSet<PrikolTransition> PrikolTransition { get; set; }
    public required DbSet<PrikolLike> PrikolLikes { get; set; }

}
