using System;
using System.Collections.Generic;

namespace CollaborationTool.Domain.Entities
{
    public class User
    {
        public Guid UserId { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }

        // Relationships
        public ICollection<Document> Documents { get; private set; }

        public User(string username, string email, string passwordHash)
        {
            UserId = Guid.NewGuid();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Documents = new List<Document>();
        }

        // Additional methods here
    }
}
