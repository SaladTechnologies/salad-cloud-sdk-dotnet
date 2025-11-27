namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class SystemLogValidator : AbstractValidator<SystemLog?>
{
    public SystemLogValidator()
    {
        RuleFor(SystemLog => SystemLog.EventName)
            .MinimumLength(1)
            .WithMessage("Minimum length for event_name is 1.")
            .MaximumLength(255)
            .WithMessage("Minimum length for event_name is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for event_name must match ^.*$.")
            .NotNull()
            .WithMessage("Field event_name is required and cannot be null.");
        RuleFor(SystemLog => SystemLog.EventTime)
            .NotNull()
            .WithMessage("Field event_time is required and cannot be null.");
        RuleFor(SystemLog => SystemLog.ResourceCpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for resource_cpu is 1.")
            .LessThanOrEqualTo(16)
            .WithMessage("Minimum for resource_cpu is 16.");
        RuleFor(SystemLog => SystemLog.ResourceGpuClass)
            .NotNull()
            .WithMessage("Field resource_gpu_class is required and cannot be null.");
        RuleFor(SystemLog => SystemLog.ResourceMemory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for resource_memory is 1024.")
            .LessThanOrEqualTo(61440)
            .WithMessage("Minimum for resource_memory is 61440.");
        RuleFor(SystemLog => SystemLog.ResourceStorageAmount)
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for resource_storage_amount is 1073741824.")
            .LessThanOrEqualTo(268435456000)
            .WithMessage("Minimum for resource_storage_amount is 268435456000.");
        RuleFor(SystemLog => SystemLog.Version)
            .NotNull()
            .WithMessage("Field version is required and cannot be null.");
    }
}
