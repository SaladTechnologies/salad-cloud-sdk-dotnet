namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationDockerHub2Validator
    : AbstractValidator<RegistryAuthenticationDockerHub2?>
{
    public RegistryAuthenticationDockerHub2Validator()
    {
        RuleFor(RegistryAuthenticationDockerHub2 => RegistryAuthenticationDockerHub2.Username)
            .NotNull()
            .WithMessage("Field username is required.");
        RuleFor(RegistryAuthenticationDockerHub2 =>
                RegistryAuthenticationDockerHub2.PersonalAccessToken
            )
            .NotNull()
            .WithMessage("Field personal_access_token is required.");
    }
}
