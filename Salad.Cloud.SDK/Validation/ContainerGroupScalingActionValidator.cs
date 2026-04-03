namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupScalingAction model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupScalingActionValidator : AbstractValidator<ContainerGroupScalingAction>
{
    public ContainerGroupScalingActionValidator()
    {
        RuleFor(ContainerGroupScalingAction => ContainerGroupScalingAction.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.")
            .NotNull()
            .WithMessage("Field replicas is required and cannot be null.");
        RuleFor(ContainerGroupScalingAction => ContainerGroupScalingAction.Schedule)
            .Matches(@"^([0-9A-Za-z*/,-]+)([\t ]+[0-9A-Za-z*/,-]+){4}$")
            .WithMessage(
                @"Pattern for schedule must match ^([0-9A-Za-z*/,-]+)([\t ]+[0-9A-Za-z*/,-]+){4}$."
            )
            .NotNull()
            .WithMessage("Field schedule is required and cannot be null.");
    }
}
