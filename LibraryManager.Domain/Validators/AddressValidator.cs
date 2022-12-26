using FluentValidation;
using LibraryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.StreetAddress).NotEmpty().WithMessage("Street Address cannot be empty");
            RuleFor(address => (int)address.Number).GreaterThan(0).WithMessage("Number cannot be empty");
            RuleFor(address => address.City).NotNull().WithMessage("City cannot be empty");
            RuleFor(address => address.Zipcode).NotEmpty().WithMessage("Zip code cannot bet empty")
                .Matches("\\d{5}-\\d{3}").WithMessage("Incorrectly formatted zip code"); // Brazil Zip Code
        }
    }
}
