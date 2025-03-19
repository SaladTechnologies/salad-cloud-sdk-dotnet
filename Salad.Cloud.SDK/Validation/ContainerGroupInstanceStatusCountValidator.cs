namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupInstanceStatusCountValidator
    : AbstractValidator<ContainerGroupInstanceStatusCount?>
{
    public ContainerGroupInstanceStatusCountValidator()
    {
        RuleFor(ContainerGroupInstanceStatusCount =>
                ContainerGroupInstanceStatusCount.AllocatingCount
            )
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for allocating_count is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for allocating_count is 2147483647.")
            .NotNull()
            .WithMessage("Field allocating_count is required.");
        RuleFor(ContainerGroupInstanceStatusCount =>
                ContainerGroupInstanceStatusCount.CreatingCount
            )
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for creating_count is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for creating_count is 2147483647.")
            .NotNull()
            .WithMessage("Field creating_count is required.");
        RuleFor(ContainerGroupInstanceStatusCount => ContainerGroupInstanceStatusCount.RunningCount)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for running_count is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for running_count is 2147483647.")
            .NotNull()
            .WithMessage("Field running_count is required.");
        RuleFor(ContainerGroupInstanceStatusCount =>
                ContainerGroupInstanceStatusCount.StoppingCount
            )
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for stopping_count is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for stopping_count is 2147483647.")
            .NotNull()
            .WithMessage("Field stopping_count is required.");
    }
}
