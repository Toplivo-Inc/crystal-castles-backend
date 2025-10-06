using Microsoft.EntityFrameworkCore;

public class CastlesDbContext : DbContext
{
    public CastlesDbContext(DbContextOptions<CastlesDbContext> options)
      : base(options)
    {


    }

    public DbSet<Generators> Generators { get; set; }
    public DbSet<Prikol> Prikols { get; set; }
    public DbSet<PrikolGenerationProcess> PrikolGenerationProcesses { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<PrikolGenerationTransition> PrikolGenerationTransition { get; set; }
    public DbSet<PrikolTransition> PrikolTransition { get; set; }
    public DbSet<PrikolLike> PrikolLikes { get; set; }

}
