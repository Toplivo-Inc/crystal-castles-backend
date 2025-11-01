namespace CrystalCastlesBackend.Models;

public class Generator
{
    public required Guid GeneratorId { get; set; }
    public required string Key { get; set; } 
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public List<Prikol>? Prikols { get; set; }
}
