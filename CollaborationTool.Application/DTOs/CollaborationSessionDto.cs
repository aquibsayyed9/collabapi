namespace CollaborationTool.Application.DTOs

public class CollaborationSessionDto
{
    public Guid SessionId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public Guid DocumentId { get; set; } // Associated DocumentId
}
