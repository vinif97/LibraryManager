using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class AuthorValidatorTest
    {
        [Fact]
        public void WhenAuthorNameIsEmptyOrNull_ReturnError()
        {
            Author author = new() { AuthorName = ""};
            AuthorValidator validator = new();
            ValidationResult validationResults = validator.Validate(author);

            string expectedError = "Author name cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }
    }
}
