using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(author => author.AuthorName).NotEmpty().WithMessage("Author name cannot be empty");
        }
    }
}
