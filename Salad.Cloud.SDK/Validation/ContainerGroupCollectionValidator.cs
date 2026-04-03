namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupCollection model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupCollectionValidator : AbstractValidator<ContainerGroupCollection>
{
    public ContainerGroupCollectionValidator()
    {
        RuleFor(ContainerGroupCollection => ContainerGroupCollection.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
    }
}
