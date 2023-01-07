using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class PublisherValidator : AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(publisher => publisher.PublisherName).NotEmpty().WithMessage("Publisher name cannot be empty");
            RuleFor(publisher => publisher.PublisherName).MaximumLength(128).WithMessage("Publisher name cannot be longer than 128 characters");
        }
    }
}
