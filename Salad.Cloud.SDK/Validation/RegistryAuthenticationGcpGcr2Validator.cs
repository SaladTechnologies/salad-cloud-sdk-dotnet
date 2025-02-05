namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationGcpGcr2Validator
    : AbstractValidator<RegistryAuthenticationGcpGcr2?>
{
    public RegistryAuthenticationGcpGcr2Validator()
    {
        RuleFor(RegistryAuthenticationGcpGcr2 => RegistryAuthenticationGcpGcr2.ServiceKey)
            .NotNull()
            .WithMessage("Field service_key is required.");
    }
}
