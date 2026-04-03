namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupInstancePatch model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupInstancePatchValidator : AbstractValidator<ContainerGroupInstancePatch>
{
    public ContainerGroupInstancePatchValidator()
    {
        RuleFor(ContainerGroupInstancePatch => ContainerGroupInstancePatch.DeletionCost)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for deletion_cost is 0.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for deletion_cost is 100000.");
    }
}
