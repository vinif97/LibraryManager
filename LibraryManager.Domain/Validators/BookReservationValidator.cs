using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class BookReservationValidator : AbstractValidator<BookReservation>
    {
        public BookReservationValidator()
        {
            RuleFor(bookReservation => bookReservation.CreationDate).NotNull().WithMessage("Creation date cannot be null");
            RuleFor(bookReservation => bookReservation.EndDate).NotNull().WithMessage("End date cannot be null");
        }
    }
}
