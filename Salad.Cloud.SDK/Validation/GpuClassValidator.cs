namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for GpuClass model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class GpuClassValidator : AbstractValidator<GpuClass>
{
    public GpuClassValidator()
    {
        RuleFor(GpuClass => GpuClass.Id)
            .NotNull()
            .WithMessage("Field id is required and cannot be null.");
        RuleFor(GpuClass => GpuClass.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[ -~]{2,63}$")
            .WithMessage(@"Pattern for name must match ^[ -~]{2,63}$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(GpuClass => GpuClass.Prices)
            .NotNull()
            .WithMessage("Field prices is required and cannot be null.");

        RuleFor(GpuClass => GpuClass.GpuCount)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for gpu_count is 1.")
            .LessThanOrEqualTo(512)
            .WithMessage("Minimum for gpu_count is 512.");

        RuleFor(GpuClass => GpuClass.MaxRam)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_ram is 0.");
        RuleFor(GpuClass => GpuClass.MaxStorage)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_storage is 0.");
        RuleFor(GpuClass => GpuClass.MaxVcpu)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_vcpu is 0.");
        RuleFor(GpuClass => GpuClass.MinRam)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for min_ram is 0.");
        RuleFor(GpuClass => GpuClass.MinStorage)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for min_storage is 0.");
        RuleFor(GpuClass => GpuClass.MinVcpu)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for min_vcpu is 0.");
    }
}
