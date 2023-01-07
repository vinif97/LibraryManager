using FluentValidation;
using FluentValidation.Results;
using LibraryManager.Application.Interfaces.ErrorHandler;
using LibraryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.ValidationHandler
{
    public static class DomainErrorProcessor<T> where T : class
    {
        public static IResult Validate(T domainClassToBeValidated, AbstractValidator<T> validator, IResult result)
        {
            ValidationResult validationResult = validator.Validate(domainClassToBeValidated);

            if (!validationResult.IsValid)
            {
                result.IsSuccess = false;

                foreach (var error in validationResult.Errors)
                {
                    result.Errors.Add(error.ToString());
                }

                return result;
            }

            result.IsSuccess = true;
            return result;
        }
    }
}
