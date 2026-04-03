namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for QueueJobPrototype model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QueueJobPrototypeValidator : AbstractValidator<QueueJobPrototype>
{
    public QueueJobPrototypeValidator()
    {
        RuleFor(QueueJobPrototype => QueueJobPrototype.Input_)
            .NotNull()
            .WithMessage("Field input is required and cannot be null.");

        RuleFor(QueueJobPrototype => QueueJobPrototype.Webhook)
            .MinimumLength(1)
            .WithMessage("Minimum length for webhook is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for webhook is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for webhook must match ^.*$.");
    }
}
