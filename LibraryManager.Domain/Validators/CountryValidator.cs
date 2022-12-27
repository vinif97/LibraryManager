using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class CountryValidator : AbstractValidator<Country>
    {
        public CountryValidator()
        {
            RuleFor(country => country.CountryName).NotEmpty().WithMessage("Country name cannot be empty");
        }
    }
}
