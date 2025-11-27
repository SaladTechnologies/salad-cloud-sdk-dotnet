namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupCollectionValidator : AbstractValidator<ContainerGroupCollection?>
{
    public ContainerGroupCollectionValidator()
    {
        RuleFor(ContainerGroupCollection => ContainerGroupCollection.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
    }
}
