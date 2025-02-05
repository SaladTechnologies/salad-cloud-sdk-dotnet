namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupInstancesValidator : AbstractValidator<ContainerGroupInstances?>
{
    public ContainerGroupInstancesValidator()
    {
        RuleFor(ContainerGroupInstances => ContainerGroupInstances.Instances)
            .NotNull()
            .WithMessage("Field instances is required.");
    }
}
