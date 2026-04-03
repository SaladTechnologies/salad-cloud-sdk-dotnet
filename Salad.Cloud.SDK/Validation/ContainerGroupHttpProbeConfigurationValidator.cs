namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupHttpProbeConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupHttpProbeConfigurationValidator
    : AbstractValidator<ContainerGroupHttpProbeConfiguration>
{
    public ContainerGroupHttpProbeConfigurationValidator()
    {
        RuleFor(ContainerGroupHttpProbeConfiguration =>
                ContainerGroupHttpProbeConfiguration.Headers
            )
            .NotNull()
            .WithMessage("Field headers is required and cannot be null.");
        RuleFor(ContainerGroupHttpProbeConfiguration => ContainerGroupHttpProbeConfiguration.Path)
            .MinimumLength(1)
            .WithMessage("Minimum length for path is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for path is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for path must match ^.*$.")
            .NotNull()
            .WithMessage("Field path is required and cannot be null.");
        RuleFor(ContainerGroupHttpProbeConfiguration => ContainerGroupHttpProbeConfiguration.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65536)
            .WithMessage("Minimum for port is 65536.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
    }
}
