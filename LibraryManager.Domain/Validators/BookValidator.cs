using FluentValidation;
using LibraryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage("Title cannot be empty")
                .MaximumLength(256).WithMessage("Title cannot be bigger than 256 characteres");
            RuleFor(book => book.Publisher).NotNull().WithMessage("Publisher cannot be null");
            RuleFor(book => (int)book.PublishedYear).GreaterThan(0).WithMessage("Published Year cannot be empty");
        }
    }
}
