using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class CountryValidatorTest
    {
        [Fact]
        public void WhenCountryNameIsEmptyOrNull_ReturnError()
        {
            Country country = new();
            CountryValidator validator = new();
            ValidationResult validationResults = validator.Validate(country);

            string expectedResult = "Country name cannot be empty";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }
    }
}
