namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationGcpGar1Validator
    : AbstractValidator<RegistryAuthenticationGcpGar1?>
{
    public RegistryAuthenticationGcpGar1Validator()
    {
        RuleFor(RegistryAuthenticationGcpGar1 => RegistryAuthenticationGcpGar1.ServiceKey)
            .NotNull()
            .WithMessage("Field service_key is required.");
    }
}
