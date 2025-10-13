namespace CrystalCastlesBackend.Models;

public class Prikol
{
    public required Guid PrikolId { get; set; }
    public string? ImageUrl { get; set; }
    public PrikolStatusEnum Status { get; set; }
    public bool IsPrivate { get; set; }
    public string? BanMessage { get; set; }
    public required User User { get; set; }
    public required Generator Generator { get; set; }
    public Guid GeneratorId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime BannedAt { get; set; }

    public List<PrikolLike>? PrikolLikes { get; set; }
    public List<Report>? Reports { get; set; }
    public required PrikolGenerationProcess PrikolGenerationProcess { get; set; }
    public List<PrikolGenerationTransition>? PrikolGenerationTransitions { get; set; }
    public List<PrikolTransition>? PrikolTransitions { get; set; }

}
