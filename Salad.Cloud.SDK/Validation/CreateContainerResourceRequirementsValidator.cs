namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateContainerResourceRequirementsValidator
    : AbstractValidator<CreateContainerResourceRequirements?>
{
    public CreateContainerResourceRequirementsValidator()
    {
        RuleFor(CreateContainerResourceRequirements => CreateContainerResourceRequirements.Cpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for cpu is 1.")
            .LessThanOrEqualTo(16)
            .WithMessage("Minimum for cpu is 16.")
            .NotNull()
            .WithMessage("Field cpu is required.");
        RuleFor(CreateContainerResourceRequirements => CreateContainerResourceRequirements.Memory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for memory is 1024.")
            .LessThanOrEqualTo(61440)
            .WithMessage("Minimum for memory is 61440.")
            .NotNull()
            .WithMessage("Field memory is required.");

        RuleFor(CreateContainerResourceRequirements =>
                CreateContainerResourceRequirements.StorageAmount
            )
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for storage_amount is 1073741824.")
            .LessThanOrEqualTo(268435456000)
            .WithMessage("Minimum for storage_amount is 268435456000.");
    }
}
