namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for QueuePrototype model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QueuePrototypeValidator : AbstractValidator<QueuePrototype>
{
    public QueuePrototypeValidator()
    {
        RuleFor(QueuePrototype => QueuePrototype.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(QueuePrototype => QueuePrototype.Description)
            .MaximumLength(500)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.");
        RuleFor(QueuePrototype => QueuePrototype.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
    }
}
