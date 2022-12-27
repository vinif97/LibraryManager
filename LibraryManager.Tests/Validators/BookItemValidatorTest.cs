using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class BookItemValidatorTest
    {
        [Fact]
        public void WhenIsReferenceOnlyIsNull_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Property 'is reference only' cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenIsVirtualIsNull_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Property 'is virtual' cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }

        [Fact]
        public void WhenLanguageIsNulll_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Book's language not specified";
            Assert.Equal(expectedError, validationResults.Errors[2].ToString());
        }

        [Fact]
        public void WhenPricePerDayIsNull_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Price cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[3].ToString());
        }

        [Fact]
        public void WhenBookIsNull_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Book cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[4].ToString());
        }

        [Fact]
        public void WhenLibraryIsNull_ReturnError()
        {
            BookItem bookItem = new();
            BookItemValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookItem);

            string expectedError = "Library cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[5].ToString());
        }
    }
}
