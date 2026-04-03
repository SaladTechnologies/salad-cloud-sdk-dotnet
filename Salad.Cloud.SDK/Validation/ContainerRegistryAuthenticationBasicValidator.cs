namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerRegistryAuthenticationBasic model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerRegistryAuthenticationBasicValidator
    : AbstractValidator<ContainerRegistryAuthenticationBasic>
{
    public ContainerRegistryAuthenticationBasicValidator()
    {
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
    }
}
