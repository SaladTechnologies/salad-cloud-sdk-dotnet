namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupInstanceValidator : AbstractValidator<ContainerGroupInstance?>
{
    public ContainerGroupInstanceValidator()
    {
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.InstanceId)
            .NotNull()
            .WithMessage("Field instance_id is required.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.MachineId)
            .NotNull()
            .WithMessage("Field machine_id is required.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.State1)
            .NotNull()
            .WithMessage("Field state is required.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.Version)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for version is 1.")
            .NotNull()
            .WithMessage("Field version is required.");
    }
}
