using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class BookValidatorTest
    {
        [Fact]
        public void WhenTitleBiggerThan256Chars_ReturnError()
        {
            Book book = new() { Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };
            BookValidator validator = new();
            ValidationResult validationResults = validator.Validate(book);

            string expectedError = "Title cannot be bigger than 256 characteres";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenTitleEmptyOrNull_ReturnError()
        {
            Book book = new() { Title = "" };
            BookValidator validatior = new();
            ValidationResult validationResults = validatior.Validate(book);

            string expectedError = "Title cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenPublisherIsNull_ReturnError()
        {
            Book book = new();
            BookValidator validator = new();
            ValidationResult validationResults = validator.Validate(book);

            string expectedError = "Publisher cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }

        [Fact]
        public void WhenPublishedYearIs0_ReturnError()
        {
            Book book = new();
            BookValidator validator = new();
            ValidationResult validationResults = validator.Validate(book);

            string expectedError = "Published Year cannot be empty";
            Assert.Equal(expectedError, validationResults.Errors[2].ToString());
        }
    }
}
