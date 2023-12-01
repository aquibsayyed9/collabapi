using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CollaborationTool.Application.DTOs;
using CollaborationTool.Application.Interfaces;

namespace CollaborationTool.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var documentDto = await _documentService.GetDocumentByIdAsync(id);
            if (documentDto == null)
            {
                return NotFound();
            }

            return Ok(documentDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DocumentDto documentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _documentService.CreateDocumentAsync(documentDto);
            return CreatedAtAction(nameof(GetById), new { id = documentDto.DocumentId }, documentDto);
        }

        [HttpPost("{documentId}/join")]
        public async Task<IActionResult> JoinSession(Guid documentId)
        {
            var sessionDto = await _collaborationSessionService.JoinSessionAsync(documentId);
            if (sessionDto == null)
            {
                return NotFound();
            }

            return Ok(sessionDto);
        }

        [HttpPost("{sessionId}/leave")]
        public async Task<IActionResult> LeaveSession(Guid sessionId)
        {
            var success = await _collaborationSessionService.LeaveSessionAsync(sessionId);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
