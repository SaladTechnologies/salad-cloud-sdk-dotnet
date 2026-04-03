namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for LogEntryCollection model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class LogEntryCollectionValidator : AbstractValidator<LogEntryCollection>
{
    public LogEntryCollectionValidator()
    {
        RuleFor(LogEntryCollection => LogEntryCollection.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
        RuleFor(LogEntryCollection => LogEntryCollection.OrganizationName)
            .MinimumLength(2)
            .WithMessage("Minimum length for organization_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for organization_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(
                @"Pattern for organization_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$."
            )
            .NotNull()
            .WithMessage("Field organization_name is required and cannot be null.");
        RuleFor(LogEntryCollection => LogEntryCollection.PageMaxTime)
            .NotNull()
            .WithMessage("Field page_max_time is required and cannot be null.");
        RuleFor(LogEntryCollection => LogEntryCollection.PageMinTime)
            .NotNull()
            .WithMessage("Field page_min_time is required and cannot be null.");
    }
}
