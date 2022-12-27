using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(city => city.CityName).NotEmpty().WithMessage("City name be empty");
            RuleFor(city => city.State).NotNull().WithMessage("State cannot be null");
        }
    }
}
