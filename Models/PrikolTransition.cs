using System.Text.Json;

namespace CrystalCastlesBackend.Models;

public class PrikolTransition
{
    public required Guid PrikolTransitionId { get; set; }
    public required Prikol Prikol { get; set; }
    public required DateTime TransitionTimestamp { get; set; }
    public PrikolStatusEnum NewState { get; set; }
    public JsonDocument? Payload { get; set; }
    public Guid? PreviousTransitionId { get; set; }
    public PrikolTransition? PreviousTransition { get; set; }
}
