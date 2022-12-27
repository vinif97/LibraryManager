using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class LibrarianValidatorTest
    {
        [Fact]
        public void WhenCountryNameIsEmptyOrNull_ReturnError()
        {
            Librarian librarian = new();
            LibrarianValidator validator = new();
            ValidationResult validationResults = validator.Validate(librarian);

            string expectedResult = "User cannot be null";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }
    }
}
