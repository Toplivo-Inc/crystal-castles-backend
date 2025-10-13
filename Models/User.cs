namespace CrystalCastlesBackend.Models;

public class User
{
    public required Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? AvatarUrl { get; set; }
    public string? EmojiStatus { get; set; }
    public string? TextStatus { get; set; }
    public required RoleEnum Role { get; set; }
    public string? BanMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? BannedAt { get; set; }

    public List<PrikolLike>? PrikolLikes { get; set; }
    public List<PrikolGenerationTransition>? PrikolGenerationTransitions { get; set; }
    public List<PrikolTransition>? PrikolTransitions { get; set; }
    public List<Prikol>? Prikols { get; set; }
    public List<Report>? Reports { get; set; }


}
