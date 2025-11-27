namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupInstanceValidator : AbstractValidator<ContainerGroupInstance?>
{
    public ContainerGroupInstanceValidator()
    {
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.Id)
            .NotNull()
            .WithMessage("Field id is required and cannot be null.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.MachineId)
            .NotNull()
            .WithMessage("Field machine_id is required and cannot be null.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.State)
            .NotNull()
            .WithMessage("Field state is required and cannot be null.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required and cannot be null.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.Version)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for version is 1.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for version is 2147483647.")
            .NotNull()
            .WithMessage("Field version is required and cannot be null.");

        RuleFor(ContainerGroupInstance => ContainerGroupInstance.SshPort)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for ssh_port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for ssh_port is 65535.");
        RuleFor(ContainerGroupInstance => ContainerGroupInstance.SshHostKeyFingerprint)
            .MinimumLength(1)
            .WithMessage("Minimum length for ssh_host_key_fingerprint is 1.")
            .MaximumLength(256)
            .WithMessage("Minimum length for ssh_host_key_fingerprint is 1.");

        RuleFor(ContainerGroupInstance => ContainerGroupInstance.DeletionCost)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for deletion_cost is 0.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for deletion_cost is 100000.");
    }
}
