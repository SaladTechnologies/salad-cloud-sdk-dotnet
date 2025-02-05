namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationDockerHub1Validator
    : AbstractValidator<RegistryAuthenticationDockerHub1?>
{
    public RegistryAuthenticationDockerHub1Validator()
    {
        RuleFor(RegistryAuthenticationDockerHub1 => RegistryAuthenticationDockerHub1.Username)
            .NotNull()
            .WithMessage("Field username is required.");
        RuleFor(RegistryAuthenticationDockerHub1 =>
                RegistryAuthenticationDockerHub1.PersonalAccessToken
            )
            .NotNull()
            .WithMessage("Field personal_access_token is required.");
    }
}
