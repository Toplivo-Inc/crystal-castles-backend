namespace CrystalCastlesBackend.Models;

public class Report
{
    public required Guid ReportId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsProcessed { get; set; }
    public Prikol? PrikolId { get; set; }
    public User? UserId { get; set; }
    public Prikol? Prikol { get; set; }
    public User? User { get; set; }
}
