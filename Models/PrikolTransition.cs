public class PrikolTransition
{
    public Guid PrikolTransitionId { get; set; }
    public Guid PrikolId { get; set; }
    public DateTime TransitionTimestamp { get; set; }
    public int NewState { get; set; }
    public int Payload { get; set; }
    public Guid PreviousTransitionId { get; set; }
}
