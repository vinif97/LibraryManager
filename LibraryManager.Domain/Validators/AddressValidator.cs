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
            RuleFor(address => address.StreetAddress).NotEmpty().NotNull().WithMessage("Street Address cannot be empty");
            RuleFor(address => address.Zipcode).Matches("\\d{5}-\\d{3}"); // Brazil Zip Code
        }
    }
}
