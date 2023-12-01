using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CollaborationTool.Application.DTOs;

public interface IDocumentService
{
    Task<IEnumerable<DocumentDto>> GetAllDocumentsAsync();
    Task<DocumentDto> GetDocumentByIdAsync(Guid documentId);
    Task CreateDocumentAsync(DocumentDto documentDto);
    // Additional methods as required
}
