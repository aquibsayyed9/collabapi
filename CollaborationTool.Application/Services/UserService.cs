using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CollaborationTool.Application.DTOs;
using CollaborationTool.Domain.Entities;
using CollaborationTool.Domain.Validators;

namespace CollaborationTool.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        // Inject other dependencies here, e.g., database context

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            // Implementation for retrieving all users
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetUserByIdAsync(Guid userId)
        {
            // Implementation for retrieving a single user by ID
            throw new NotImplementedException();
        }

        public async Task CreateUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var validator = new UserValidator();
            var validationResult = validator.Validate(user);

            if (!validationResult.IsValid)
            {
                // Handle validation failure
                var errorMessage = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(errorMessage);
            }

            // Implementation for creating a user
        }
    }
}