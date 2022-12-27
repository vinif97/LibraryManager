using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class LibraryValidator : AbstractValidator<Library>
    {
        public LibraryValidator()
        {
            RuleFor(library => library.Name).NotEmpty().WithMessage("Library name cannot be empty");
            RuleFor(library => library.Address).NotNull().WithMessage("Library address cannot be null");
        }
    }
}
