namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationBasic1Validator
    : AbstractValidator<RegistryAuthenticationBasic1?>
{
    public RegistryAuthenticationBasic1Validator()
    {
        RuleFor(RegistryAuthenticationBasic1 => RegistryAuthenticationBasic1.Username)
            .NotNull()
            .WithMessage("Field username is required.");
        RuleFor(RegistryAuthenticationBasic1 => RegistryAuthenticationBasic1.Password)
            .NotNull()
            .WithMessage("Field password is required.");
    }
}
