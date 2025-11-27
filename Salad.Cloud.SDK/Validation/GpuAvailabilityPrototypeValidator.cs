namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class GpuAvailabilityPrototypeValidator : AbstractValidator<GpuAvailabilityPrototype?>
{
    public GpuAvailabilityPrototypeValidator()
    {
        RuleFor(GpuAvailabilityPrototype => GpuAvailabilityPrototype.GpuClasses)
            .NotNull()
            .WithMessage("Field gpu_classes is required and cannot be null.");
    }
}
