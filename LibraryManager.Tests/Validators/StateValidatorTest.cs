using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class StateValidatorTest
    {
        [Fact]
        public void WhenStateNameIsEmptyOrNull_ReturnError()
        {
            State state = new();
            StateValidator validator = new();
            ValidationResult validationResults = validator.Validate(state);

            string expectedResult = "State name cannot be empty";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenCountryIsNull_ReturnError()
        {
            State state = new();
            StateValidator validator = new();
            ValidationResult validationResults = validator.Validate(state);

            string expectedResult = "Country cannot be null";
            Assert.Equal(expectedResult, validationResults.Errors[1].ToString());
        }
    }
}
