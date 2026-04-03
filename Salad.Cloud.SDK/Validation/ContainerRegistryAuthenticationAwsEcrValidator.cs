namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerRegistryAuthenticationAwsEcr model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerRegistryAuthenticationAwsEcrValidator
    : AbstractValidator<ContainerRegistryAuthenticationAwsEcr>
{
    public ContainerRegistryAuthenticationAwsEcrValidator()
    {
        RuleFor(ContainerRegistryAuthenticationAwsEcr =>
                ContainerRegistryAuthenticationAwsEcr.AccessKeyId
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for access_key_id is 1.")
            .MaximumLength(10000)
            .WithMessage("Minimum length for access_key_id is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for access_key_id must match ^.*$.")
            .NotNull()
            .WithMessage("Field access_key_id is required and cannot be null.");
        RuleFor(ContainerRegistryAuthenticationAwsEcr =>
                ContainerRegistryAuthenticationAwsEcr.SecretAccessKey
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for secret_access_key is 1.")
            .MaximumLength(10000)
            .WithMessage("Minimum length for secret_access_key is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for secret_access_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field secret_access_key is required and cannot be null.");
    }
}
