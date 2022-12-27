using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;
using System.Linq;

namespace LibraryManager.Domain.Tests.Validators
{
    public class AddressValidatorTest
    {
        [Fact]
        public void WhenStreetAddressIsEmptyOrNull_ReturnError()
        {
            Address address = new();
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            string expectedError = "Street Address cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenNumber0_ReturnError()
        {
            Address address = new();
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            string expectedError = "Number cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }

        [Fact]
        public void WhenCityIsNull_ReturnError()
        {
            Address address = new();
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            string expectedError = "City cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[2].ToString());
        }

        [Fact]
        public void WhenZipCodeIsEmptyOrNull_ReturnError()
        {
            Address address = new() { };
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            string expectedError = "Zip code cannot bet empty";
            Assert.Equal(expectedError, validationResults.Errors[3].ToString());
        }

        [Fact]
        public void WhenZipCodeIsIncorrectlyFormatted_ReturnError()
        {
            Address address = new() { Zipcode = "123-456"};
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            string expectedError = "Incorrectly formatted zip code";
            Assert.Equal(expectedError, validationResults.Errors[3].ToString());
        }

        [Fact]
        public void WhenZipCodeIsCorrectlyFormatted_DontReturnError()
        {
            Address address = new() { Zipcode = "12345-678" };
            AddressValidator validator = new();
            ValidationResult validationResults = validator.Validate(address);

            Assert.Null(validationResults.Errors.ElementAtOrDefault(3));
        }
    }
}
