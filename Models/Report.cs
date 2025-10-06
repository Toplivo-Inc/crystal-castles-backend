public class Report
{
    public Guid GeneratorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsProcessed { get; set; }
    public Guid PrikolId { get; set; }
    public Guid UserId { get; set; }
}
