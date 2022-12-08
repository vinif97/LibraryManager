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
            RuleFor(book => book.Title).NotNull().NotEmpty().WithMessage("Title cannot be empty").MaximumLength(256).WithMessage("Title cannot be bigger than 256 characteres");
        }
    }
}
