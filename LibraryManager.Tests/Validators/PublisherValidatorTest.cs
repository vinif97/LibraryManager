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
    }
}
