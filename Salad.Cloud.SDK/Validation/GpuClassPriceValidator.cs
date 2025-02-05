namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class GpuClassPriceValidator : AbstractValidator<GpuClassPrice?>
{
    public GpuClassPriceValidator()
    {
        RuleFor(GpuClassPrice => GpuClassPrice.Priority)
            .NotNull()
            .WithMessage("Field priority is required.");
        RuleFor(GpuClassPrice => GpuClassPrice.Price)
            .MinimumLength(1)
            .WithMessage("Minimum length for price is 1.")
            .MaximumLength(20)
            .WithMessage("Minimum length for price is 1.")
            .NotNull()
            .WithMessage("Field price is required.");
    }
}
