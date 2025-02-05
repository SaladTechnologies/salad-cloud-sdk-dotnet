namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationAwsEcr1Validator
    : AbstractValidator<RegistryAuthenticationAwsEcr1?>
{
    public RegistryAuthenticationAwsEcr1Validator()
    {
        RuleFor(RegistryAuthenticationAwsEcr1 => RegistryAuthenticationAwsEcr1.AccessKeyId)
            .NotNull()
            .WithMessage("Field access_key_id is required.");
        RuleFor(RegistryAuthenticationAwsEcr1 => RegistryAuthenticationAwsEcr1.SecretAccessKey)
            .NotNull()
            .WithMessage("Field secret_access_key is required.");
    }
}
