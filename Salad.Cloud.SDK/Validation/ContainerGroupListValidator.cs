namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupListValidator : AbstractValidator<ContainerGroupList?>
{
    public ContainerGroupListValidator()
    {
        RuleFor(ContainerGroupList => ContainerGroupList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
