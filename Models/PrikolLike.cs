namespace CrystalCastlesBackend.Models;


public class PrikolLike
{
    public required Guid PrikolLikeId { get; set; }
    public required Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public required Guid PrikolId { get; set; }
    public Prikol Prikol { get; set; } = null!;
    public required DateTime CreatedAt { get; set; }
}
