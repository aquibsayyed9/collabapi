using FluentValidation
using CollaborationTool.Domain.Entities;

namespace CollaborationTool.Domain.Validators
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(document => document.Title)
            .NotEmpty()
            .WithMessage("Title is required")
            .Length(1, 100)
            .WithMessage("Title must be between 1 and 100 characters");

            RuleFor(document => document.Content)
            .NotEmpty()
            .WithMessage("Content is required");

        }
    }
}