using System.Text.Json;

namespace CrystalCastlesBackend.Models;

public class PrikolTransition
{
    public required Guid PrikolTransitionId { get; set; }
    public required Guid PrikolId { get; set; }
    public Prikol Prikol { get; set; } = null!;
    public required DateTime TransitionTimestamp { get; set; }
    public User User { get; set; } = null!;
    public required Guid UserId { get; set; }
    public PrikolStatusEnum NewState { get; set; }
    public JsonDocument? Payload { get; set; }
    public Guid? PreviousTransitionId { get; set; }
    public PrikolTransition? PreviousTransition { get; set; }
}
