namespace CrystalCastlesBackend.Models;


public class PrikolLike
{
    public Guid PrikolLikeId { get; set; }
    public Guid UserId { get; set; }
    public Guid PrikolId { get; set; }
    public DateTime CreatedAt { get; set; }
}
