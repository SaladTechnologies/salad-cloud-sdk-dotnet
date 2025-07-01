namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerResourceUpdateSchemaValidator
    : AbstractValidator<ContainerResourceUpdateSchema?>
{
    public ContainerResourceUpdateSchemaValidator()
    {
        RuleFor(ContainerResourceUpdateSchema => ContainerResourceUpdateSchema.Cpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for cpu is 1.")
            .LessThanOrEqualTo(16)
            .WithMessage("Minimum for cpu is 16.");
        RuleFor(ContainerResourceUpdateSchema => ContainerResourceUpdateSchema.Memory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for memory is 1024.")
            .LessThanOrEqualTo(61440)
            .WithMessage("Minimum for memory is 61440.");

        RuleFor(ContainerResourceUpdateSchema => ContainerResourceUpdateSchema.StorageAmount)
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for storage_amount is 1073741824.")
            .LessThanOrEqualTo(268435456000)
            .WithMessage("Minimum for storage_amount is 268435456000.");
        RuleFor(ContainerResourceUpdateSchema => ContainerResourceUpdateSchema.ShmSize)
            .GreaterThanOrEqualTo(64)
            .WithMessage("Minimum for shm_size is 64.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for shm_size is 2147483647.");
    }
}
