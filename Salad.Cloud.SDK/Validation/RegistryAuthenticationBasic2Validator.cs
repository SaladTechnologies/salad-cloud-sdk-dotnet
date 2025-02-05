namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationBasic2Validator
    : AbstractValidator<RegistryAuthenticationBasic2?>
{
    public RegistryAuthenticationBasic2Validator()
    {
        RuleFor(RegistryAuthenticationBasic2 => RegistryAuthenticationBasic2.Username)
            .NotNull()
            .WithMessage("Field username is required.");
        RuleFor(RegistryAuthenticationBasic2 => RegistryAuthenticationBasic2.Password)
            .NotNull()
            .WithMessage("Field password is required.");
    }
}
