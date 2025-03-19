namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupInstanceCollectionValidator
    : AbstractValidator<ContainerGroupInstanceCollection?>
{
    public ContainerGroupInstanceCollectionValidator()
    {
        RuleFor(ContainerGroupInstanceCollection => ContainerGroupInstanceCollection.Instances)
            .NotNull()
            .WithMessage("Field instances is required.");
    }
}
