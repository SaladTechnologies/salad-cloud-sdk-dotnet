namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerRegistryAuthenticationGcpGcrValidator
    : AbstractValidator<ContainerRegistryAuthenticationGcpGcr?>
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
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for service_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field service_key is required.");
    }
}
