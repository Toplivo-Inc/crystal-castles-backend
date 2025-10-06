public class Prikol
{
    public Guid PrikolId { get; set; }
    public string ImageUrl { get; set; }
    public bool IsPrivate { get; set; }
    public string BanMessage { get; set; }
    public Guid UserId { get; set; }
    public Guid GeneratorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime BannedAt { get; set; }
}
