namespace CrystalCastlesBackend.Models;

public class Prikol
{
    public required Guid PrikolId { get; set; }
    public string? ImageUrl { get; set; }
    public PrikolStatusEnum Status { get; set; }
    public string? Description { get; set; }
    public string? BanMessage { get; set; }
    public User User { get; set; } = null!;
    public Generator Generator { get; set; }
    public Guid GeneratorId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime BannedAt { get; set; }

    public List<PrikolLike>? PrikolLikes { get; set; }
    public List<Report>? Reports { get; set; }
    public PrikolGenerationProcess PrikolGenerationProcess { get; set; } = null!;
    public List<PrikolGenerationTransition>? PrikolGenerationTransitions { get; set; }
    public List<PrikolTransition>? PrikolTransitions { get; set; }

}
