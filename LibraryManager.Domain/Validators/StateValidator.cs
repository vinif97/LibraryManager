using FluentValidation;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Validators
{
    public class StateValidator : AbstractValidator<State>
    {
        public StateValidator()
        {
            RuleFor(state => state.StateName).NotEmpty().WithMessage("State name cannot be empty");
            RuleFor(state => state.Country).NotNull().WithMessage("Country cannot be null");
        }
    }
}
