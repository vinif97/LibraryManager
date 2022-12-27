using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class BookReservationValidatorTest
    {
        [Fact]
        public void WhenCreationDateIsNull_ReturnError()
        {
            BookReservation bookReservation = new();
            BookReservationValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookReservation);

            string expectedError = "Creation date cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[0].ToString());
        }

        [Fact]
        public void WhenEndDateIsNull_ReturnError()
        {
            BookReservation bookReservation = new();
            BookReservationValidator validator = new();
            ValidationResult validationResults = validator.Validate(bookReservation);

            string expectedError = "End date cannot be null";
            Assert.Equal(expectedError, validationResults.Errors[1].ToString());
        }
    }
}
