namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for QueuePatch model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QueuePatchValidator : AbstractValidator<QueuePatch>
{
    public QueuePatchValidator()
    {
        RuleFor(QueuePatch => QueuePatch.Description)
            .MaximumLength(500)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.");
        RuleFor(QueuePatch => QueuePatch.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
    }
}
