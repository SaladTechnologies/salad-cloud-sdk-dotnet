namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for QueueJobEvent model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QueueJobEventValidator : AbstractValidator<QueueJobEvent>
{
    public QueueJobEventValidator()
    {
        RuleFor(QueueJobEvent => QueueJobEvent.Action)
            .NotNull()
            .WithMessage("Field action is required and cannot be null.");
        RuleFor(QueueJobEvent => QueueJobEvent.Time)
            .NotNull()
            .WithMessage("Field time is required and cannot be null.");
    }
}
