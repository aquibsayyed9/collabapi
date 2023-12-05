using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CollaborationTool.Application.DTOs;
using CollaborationTool.Application.Services;

namespace CollaborationTool.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var userDto = await _userService.GetUserByIdAsync(id);
            if (userDto == null)
            {
                return NotFound();
            }

            return Ok(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _userService.CreateUserAsync(userDto);
            return CreatedAtAction(nameof(GetById), new { id = userDto.UserId }, userDto);
        }

        // Additional methods like Update, Delete can be added here
    }
}
