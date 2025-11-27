namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerRegistryAuthenticationBasicValidator
    : AbstractValidator<ContainerRegistryAuthenticationBasic?>
{
    public ContainerRegistryAuthenticationBasicValidator()
    {
        RuleFor(ContainerRegistryAuthenticationBasic =>
                ContainerRegistryAuthenticationBasic.Username
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for username is 1.")
            .MaximumLength(10000)
            .WithMessage("Minimum length for username is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for username must match ^.*$.")
            .NotNull()
            .WithMessage("Field username is required and cannot be null.");
        RuleFor(ContainerRegistryAuthenticationBasic =>
                ContainerRegistryAuthenticationBasic.Password
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for password is 1.")
            .MaximumLength(10000)
            .WithMessage("Minimum length for password is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for password must match ^.*$.")
            .NotNull()
            .WithMessage("Field password is required and cannot be null.");
    }
}
