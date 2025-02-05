namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class GpuClassValidator : AbstractValidator<GpuClass?>
{
    public GpuClassValidator()
    {
        RuleFor(GpuClass => GpuClass.Id).NotNull().WithMessage("Field id is required.");
        RuleFor(GpuClass => GpuClass.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(GpuClass => GpuClass.Prices).NotNull().WithMessage("Field prices is required.");
    }
}
