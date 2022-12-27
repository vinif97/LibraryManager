using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class BookLendingValidator : AbstractValidator<BookLending>
    {
        public BookLendingValidator()
        {
            RuleFor(bookLending => bookLending.CreationDate).NotNull().WithMessage("Creation date cannot be null");
            RuleFor(bookLending => bookLending.DueDate).NotNull().WithMessage("Due date cannot be null");
            RuleFor(bookLending => bookLending.Member).NotNull().WithMessage("Book cannot be borrowed without being associated with a member");
            RuleFor(bookLending => bookLending.BookItem).NotNull().WithMessage("Book to be borrow cannot be null");
        }
    }
}
