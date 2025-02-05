namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationGcpGcr1Validator
    : AbstractValidator<RegistryAuthenticationGcpGcr1?>
{
    public RegistryAuthenticationGcpGcr1Validator()
    {
        RuleFor(RegistryAuthenticationGcpGcr1 => RegistryAuthenticationGcpGcr1.ServiceKey)
            .NotNull()
            .WithMessage("Field service_key is required.");
    }
}
