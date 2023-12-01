using System;

namespace CollaborationTool.Domain.Entities
{
    public class CollaborationSession
    {
        public Guid SessionId { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }

        // Relationships
        public Guid DocumentId { get; private set; }
        public Document Document { get; private set; }

        public CollaborationSession(Guid documentId)
        {
            SessionId = Guid.NewGuid();
            StartTime = DateTime.UtcNow;
            DocumentId = documentId;
        }

        public void EndSession()
        {
            EndTime = DateTime.UtcNow;
        }

        // Additional methods here
    }
}
