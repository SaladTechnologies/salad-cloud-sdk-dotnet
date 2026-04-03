namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for QueueJobCollection model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QueueJobCollectionValidator : AbstractValidator<QueueJobCollection>
{
    public QueueJobCollectionValidator()
    {
        RuleFor(QueueJobCollection => QueueJobCollection.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
    }
}
