namespace CollaborationTool.Application.DTOs

public class DocumentDto
{
    public Guid DocumentId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Guid UserId { get; set; }
}