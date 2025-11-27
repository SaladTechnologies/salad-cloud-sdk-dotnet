namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class GpuClassPriceValidator : AbstractValidator<GpuClassPrice?>
{
    public GpuClassPriceValidator()
    {
        RuleFor(GpuClassPrice => GpuClassPrice.Price)
            .MinimumLength(1)
            .WithMessage("Minimum length for price is 1.")
            .MaximumLength(20)
            .WithMessage("Minimum length for price is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for price must match ^.*$.")
            .NotNull()
            .WithMessage("Field price is required and cannot be null.");
    }
}
