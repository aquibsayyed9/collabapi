using System;
using System.Collections.Generic;

namespace CollaborationTool.Domain.Entities
{
    public class Document
    {
        public Guid DocumentId { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }

        // Relationships
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public ICollection<CollaborationSession> CollaborationSessions { get; private set; }

        public Document(string title, string content, Guid userId)
        {
            DocumentId = Guid.NewGuid();
            Title = title;
            Content = content;
            UserId = userId;
            CollaborationSessions = new List<CollaborationSession>();
        }

        // Additional methods here
    }
}
