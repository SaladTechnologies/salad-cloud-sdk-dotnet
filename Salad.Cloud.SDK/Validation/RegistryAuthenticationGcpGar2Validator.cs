namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationGcpGar2Validator
    : AbstractValidator<RegistryAuthenticationGcpGar2?>
{
    public RegistryAuthenticationGcpGar2Validator()
    {
        RuleFor(RegistryAuthenticationGcpGar2 => RegistryAuthenticationGcpGar2.ServiceKey)
            .NotNull()
            .WithMessage("Field service_key is required.");
    }
}
