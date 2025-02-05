namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ResourcesValidator : AbstractValidator<Resources?>
{
    public ResourcesValidator()
    {
        RuleFor(Resources => Resources.Cpu)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for cpu is 1.")
            .LessThanOrEqualTo(16)
            .WithMessage("Minimum for cpu is 16.");
        RuleFor(Resources => Resources.Memory)
            .GreaterThanOrEqualTo(1024)
            .WithMessage("Minimum for memory is 1024.")
            .LessThanOrEqualTo(61440)
            .WithMessage("Minimum for memory is 61440.");

        RuleFor(Resources => Resources.StorageAmount)
            .GreaterThanOrEqualTo(1073741824)
            .WithMessage("Minimum for storage_amount is 1073741824.")
            .LessThanOrEqualTo(53687091200)
            .WithMessage("Minimum for storage_amount is 53687091200.");
    }
}
