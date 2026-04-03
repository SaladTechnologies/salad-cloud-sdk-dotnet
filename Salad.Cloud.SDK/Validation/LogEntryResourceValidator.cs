namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for LogEntryResource model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class LogEntryResourceValidator : AbstractValidator<LogEntryResource>
{
    public LogEntryResourceValidator()
    {
        RuleFor(LogEntryResource => LogEntryResource.Labels)
            .NotNull()
            .WithMessage("Field labels is required and cannot be null.");
        RuleFor(LogEntryResource => LogEntryResource.Type_)
            .MinimumLength(1)
            .WithMessage("Minimum length for type is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for type is 1.")
            .NotNull()
            .WithMessage("Field type is required and cannot be null.");
    }
}
