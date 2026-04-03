namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for LogEntryQuery model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class LogEntryQueryValidator : AbstractValidator<LogEntryQuery>
{
    public LogEntryQueryValidator()
    {
        RuleFor(LogEntryQuery => LogEntryQuery.EndTime)
            .NotNull()
            .WithMessage("Field end_time is required and cannot be null.");
        RuleFor(LogEntryQuery => LogEntryQuery.Query)
            .MaximumLength(20000)
            .WithMessage("Minimum length for query is 0.")
            .NotNull()
            .WithMessage("Field query is required and cannot be null.");
        RuleFor(LogEntryQuery => LogEntryQuery.StartTime)
            .NotNull()
            .WithMessage("Field start_time is required and cannot be null.");
        RuleFor(LogEntryQuery => LogEntryQuery.PageSize)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for page_size is 1.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for page_size is 100.");
    }
}
