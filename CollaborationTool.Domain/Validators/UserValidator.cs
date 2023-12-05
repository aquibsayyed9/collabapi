using CollaborationTool.Domain.Entities;
using FluentValidation;

namespace CollaborationTool.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username).NotEmpty().Length(3, 50);
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.PasswordHash).NotEmpty();
        }
    }
}
