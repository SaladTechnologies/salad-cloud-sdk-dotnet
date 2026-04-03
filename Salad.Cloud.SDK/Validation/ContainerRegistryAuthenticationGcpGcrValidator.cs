namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerRegistryAuthenticationGcpGcr model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerRegistryAuthenticationGcpGcrValidator
    : AbstractValidator<ContainerRegistryAuthenticationGcpGcr>
{
    public ContainerRegistryAuthenticationGcpGcrValidator()
    {
        RuleFor(ContainerRegistryAuthenticationGcpGcr =>
                ContainerRegistryAuthenticationGcpGcr.ServiceKey
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for service_key is 1.")
            .MaximumLength(10000)
            .WithMessage("Minimum length for service_key is 1.")
            .NotNull()
            .WithMessage("Field service_key is required and cannot be null.");
    }
}
