using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class BookItemValidator : AbstractValidator<BookItem>
    {
        public BookItemValidator()
        {
            RuleFor(bookItem => bookItem.IsReferenceOnly).NotNull().WithMessage("Property 'is reference only' cannot be null");
            RuleFor(bookItem => bookItem.IsVirtual).NotNull().WithMessage("Property 'is virtual' cannot be null");
            RuleFor(bookItem => bookItem.Language).IsInEnum().WithMessage("Book's language not specified");
            RuleFor(bookItem => bookItem.PricePerDay).NotNull().WithMessage("Price cannot be null");
            RuleFor(bookItem => bookItem.Book).NotNull().WithMessage("Book cannot be null");
            RuleFor(bookItem => bookItem.Library).NotNull().WithMessage("Library cannot be null");
        }
    }
}
