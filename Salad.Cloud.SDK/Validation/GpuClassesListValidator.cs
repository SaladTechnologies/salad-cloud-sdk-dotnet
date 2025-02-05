namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class GpuClassesListValidator : AbstractValidator<GpuClassesList?>
{
    public GpuClassesListValidator()
    {
        RuleFor(GpuClassesList => GpuClassesList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
