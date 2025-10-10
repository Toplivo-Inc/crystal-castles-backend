using System.Text.Json;
namespace CrystalCastlesBackend.Models;

public class PrikolGenerationTransition
{
    public required Guid PrikolGenerationTransitionId { get; set; }
    public required Prikol Prikol { get; set; }
    public Guid PrikolId { get; set; }
    public DateTime TransitionTimestamp { get; set; }
    public required User User { get; set; }
    public Guid UserId { get; set; }
    public PrikolGenerationStatusEnum NewState { get; set; }
    public JsonDocument? Payload { get; set; }
    public Guid? PreviousTransitionId { get; set; }
    public PrikolGenerationTransition? PreviousTransition { get; set; }
}
