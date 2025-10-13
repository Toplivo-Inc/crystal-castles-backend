namespace CrystalCastlesBackend.Models;


public class PrikolLike
{
    public required Guid PrikolLikeId { get; set; }
    public required Guid UserId { get; set; }
    public required User User { get; set; }
    public required Guid PrikolId { get; set; }
    public required Prikol Prikol { get; set; }
    public required DateTime CreatedAt { get; set; }
}
