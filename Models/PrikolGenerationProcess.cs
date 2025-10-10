namespace CrystalCastlesBackend.Models;

public class PrikolGenerationProcess
{
    public required Guid PrikolId { get; set; }
    public PrikolGenerationStatusEnum Status { get; set; }
    public string? ErrorMessage { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}

