using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CollaborationTool.Application.DTOs;
using CollaborationTool.Application.Services;

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

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(Guid id, [FromBody] DocumentDto documentDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var success = await _documentService.UpdateDocumentAsync(id, documentDto);
        //    if (!success)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent(); // or return Ok(documentDto) based on your API design
        //}

        //[HttpGet("user/{userId}")]
        //public async Task<IActionResult> GetDocumentsByUser(Guid userId)
        //{
        //    var documents = await _documentService.GetDocumentsByUserIdAsync(userId);
        //    return Ok(documents);
        //}
    }
}
