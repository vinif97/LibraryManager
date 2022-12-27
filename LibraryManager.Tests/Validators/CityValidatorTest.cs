using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class CityValidatorTest
    {
        [Fact]
        public void WhenCityNameIsEmptyOrNull_ReturnError()
        {
            City city = new() { CityName = ""};
            CityValidator validator = new();
            ValidationResult validationResults = validator.Validate(city);

            string expectedError = "City name be empty";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenStateIsNull_ReturnError()
        {
            City city = new();
            CityValidator validator = new();
            ValidationResult validationResults = validator.Validate(city);

            string expectedError = "State cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }
    }
}
