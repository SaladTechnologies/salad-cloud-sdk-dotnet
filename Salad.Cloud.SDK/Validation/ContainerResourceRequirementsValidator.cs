namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerResourceRequirementsValidator
    : AbstractValidator<ContainerResourceRequirements?>
{
    public ContainerResourceRequirementsValidator()
    {
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.Cpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for cpu is 1.")
            .LessThanOrEqualTo(16)
            .WithMessage("Minimum for cpu is 16.")
            .NotNull()
            .WithMessage("Field cpu is required.");
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.Memory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for memory is 1024.")
            .LessThanOrEqualTo(61440)
            .WithMessage("Minimum for memory is 61440.")
            .NotNull()
            .WithMessage("Field memory is required.");

        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.StorageAmount)
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for storage_amount is 1073741824.")
            .LessThanOrEqualTo(53687091200)
            .WithMessage("Minimum for storage_amount is 53687091200.");
    }
}
