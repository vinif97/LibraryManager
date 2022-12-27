using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class BookLendingValidatorTest
    {
        [Fact]
        public void WhenCreationDateIsNull_ReturnError()
        {
            BookLending bookLending = new();
            BookLendingValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookLending);

            string expectedError = "Creation date cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenDueDateIsNull_ReturnError()
        {
            BookLending bookLending = new();
            BookLendingValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookLending);

            string expectedError = "Due date cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }

        [Fact]
        public void WhenMemberIsNull_ReturnError()
        {
            BookLending bookLending = new();
            BookLendingValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookLending);

            string expectedError = "Book cannot be borrowed without being associated with a member";
            Assert.Equal(expectedError, validationResults.Errors[2].ToString());
        }

        [Fact]
        public void WhenBookItemIsNull_ReturnError()
        {
            BookLending bookLending = new();
            BookLendingValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookLending);

            string expectedError = "Book to be borrow cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[3].ToString());
        }
    }
}
