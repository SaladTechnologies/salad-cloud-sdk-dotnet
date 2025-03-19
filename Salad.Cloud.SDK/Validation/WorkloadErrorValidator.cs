namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class WorkloadErrorValidator : AbstractValidator<WorkloadError?>
{
    public WorkloadErrorValidator()
    {
        RuleFor(WorkloadError => WorkloadError.AllocatedAt)
            .NotNull()
            .WithMessage("Field allocated_at is required.");
        RuleFor(WorkloadError => WorkloadError.Detail)
            .MinimumLength(1)
            .WithMessage("Minimum length for detail is 1.")
            .MaximumLength(255)
            .WithMessage("Minimum length for detail is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for detail must match ^.*$.")
            .NotNull()
            .WithMessage("Field detail is required.");
        RuleFor(WorkloadError => WorkloadError.FailedAt)
            .NotNull()
            .WithMessage("Field failed_at is required.");
        RuleFor(WorkloadError => WorkloadError.InstanceId)
            .NotNull()
            .WithMessage("Field instance_id is required.");
        RuleFor(WorkloadError => WorkloadError.MachineId)
            .NotNull()
            .WithMessage("Field machine_id is required.");
        RuleFor(WorkloadError => WorkloadError.Version)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for version is 1.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for version is 2147483647.")
            .NotNull()
            .WithMessage("Field version is required.");
    }
}
