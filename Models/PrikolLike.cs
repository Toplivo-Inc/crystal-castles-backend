namespace CrystalCastlesBackend.Models;


public class PrikolLike
{
    public required Guid PrikolLikeId { get; set; }
    public required User UserId { get; set; }
    public required Prikol PrikolId { get; set; }
    public required DateTime CreatedAt { get; set; }
}
