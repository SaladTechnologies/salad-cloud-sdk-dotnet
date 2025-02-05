namespace Salad.Cloud.SDK.Http.Exceptions;

using System;
using FluentValidation.Results;

public class ValidationException : Exception
{
    public List<ValidationFailure> ValidationFailure { get; }

    public ValidationException(List<ValidationFailure> validationFailure)
        : base("Validation failed.")
    {
        ValidationFailure =
            validationFailure ?? throw new ArgumentNullException(nameof(validationFailure));
    }
}
