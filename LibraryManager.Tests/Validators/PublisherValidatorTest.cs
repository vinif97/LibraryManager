using FluentValidation.Results;
using LibraryManager.Domain.Models;
using LibraryManager.Domain.Validators;

namespace LibraryManager.Domain.Tests.Validators
{
    public class PublisherValidatorTest
    {
        [Fact]
        public void WhenPublisherNameIsEmptyOrNull_ReturnError()
        {
            Publisher publisher = new();
            PublisherValidator validator = new();
            ValidationResult validationResults = validator.Validate(publisher);

            string expectedResult = "Publisher name cannot be empty";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }
        [Fact]
        public void WhenPublisherNameIsLongerThan128Characters_ReturnError()
        {
            Publisher publisher = new()
            {
                PublisherName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };
            PublisherValidator validator = new();
            ValidationResult validationResults = validator.Validate(publisher);

            string expectedResult = "Publisher name cannot be longer than 128 characters";
            Assert.Equal(expectedResult, validationResults.Errors[0].ToString());
        }
    }
}
