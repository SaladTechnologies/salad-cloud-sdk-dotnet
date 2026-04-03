namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for GpuAvailabilityPrototype model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class GpuAvailabilityPrototypeValidator : AbstractValidator<GpuAvailabilityPrototype>
{
    public GpuAvailabilityPrototypeValidator()
    {
        RuleFor(GpuAvailabilityPrototype => GpuAvailabilityPrototype.GpuClasses)
            .NotNull()
            .WithMessage("Field gpu_classes is required and cannot be null.");
    }
}
