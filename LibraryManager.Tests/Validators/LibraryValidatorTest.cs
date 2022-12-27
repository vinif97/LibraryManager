using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class LibraryValidatorTest
    {
        [Fact]
        public void WhenLibraryNameIsEmptyOrNull_ReturnError()
        {
            Library library = new();
            LibraryValidator validator = new();
            ValidationResult validationResults = validator.Validate(library);

            string expectedResult = "Library name cannot be empty";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenAddressIsrNull_ReturnError()
        {
            Library library = new();
            LibraryValidator validator = new();
            ValidationResult validationResults = validator.Validate(library);

            string expectedResult = "Library address cannot be null";
            Assert.Equal(expectedResult, validationResults.Errors[1].ToString());
        }
    }
}
