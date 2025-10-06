public class PrikolGenerationTransition
{
    public Guid PrikolGenerationTransitionId { get; set; }
    public Guid PrikolId { get; set; }
    public DateTime TransitionTimestamp { get; set; }
    public Guid UserId { get; set; }
    public int NewState { get; set; }
    public int Payload { get; set; }
    public Guid PreviousTransitionId { get; set; }

}
