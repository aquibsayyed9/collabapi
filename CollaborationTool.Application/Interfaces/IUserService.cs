using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CollaborationTool.Application.DTOs;
namespace CollaborationTool.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(Guid userId);
        Task CreateUserAsync(UserDto userDto);
        // Additional methods as required
    }
}