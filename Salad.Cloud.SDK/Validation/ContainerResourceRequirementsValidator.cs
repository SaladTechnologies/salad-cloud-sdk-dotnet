namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerResourceRequirements model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerResourceRequirementsValidator
    : AbstractValidator<ContainerResourceRequirements>
{
    public ContainerResourceRequirementsValidator()
    {
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.Cpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for cpu is 1.")
            .LessThanOrEqualTo(1024)
            .WithMessage("Minimum for cpu is 1024.")
            .NotNull()
            .WithMessage("Field cpu is required and cannot be null.");
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.GpuClasses)
            .NotNull()
            .WithMessage("Field gpu_classes is required and cannot be null.");
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.Memory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for memory is 1024.")
            .LessThanOrEqualTo(1073741824)
            .WithMessage("Minimum for memory is 1073741824.")
            .NotNull()
            .WithMessage("Field memory is required and cannot be null.");
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.ShmSize)
            .GreaterThanOrEqualTo(64)
            .WithMessage("Minimum for shm_size is 64.")
            .LessThanOrEqualTo(1073741824)
            .WithMessage("Minimum for shm_size is 1073741824.");
        RuleFor(ContainerResourceRequirements => ContainerResourceRequirements.StorageAmount)
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for storage_amount is 1073741824.")
            .LessThanOrEqualTo(1125899906842624)
            .WithMessage("Minimum for storage_amount is 1125899906842624.");
    }
}
