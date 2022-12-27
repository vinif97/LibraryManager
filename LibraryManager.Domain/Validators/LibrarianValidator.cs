using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class LibrarianValidator : AbstractValidator<Librarian>
    {
        public LibrarianValidator()
        {
            RuleFor(librarian => librarian.User).NotNull().WithMessage("User cannot be null");
        }
    }
}
