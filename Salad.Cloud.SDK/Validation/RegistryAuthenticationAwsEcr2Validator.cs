namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class RegistryAuthenticationAwsEcr2Validator
    : AbstractValidator<RegistryAuthenticationAwsEcr2?>
{
    public RegistryAuthenticationAwsEcr2Validator()
    {
        RuleFor(RegistryAuthenticationAwsEcr2 => RegistryAuthenticationAwsEcr2.AccessKeyId)
            .NotNull()
            .WithMessage("Field access_key_id is required.");
        RuleFor(RegistryAuthenticationAwsEcr2 => RegistryAuthenticationAwsEcr2.SecretAccessKey)
            .NotNull()
            .WithMessage("Field secret_access_key is required.");
    }
}
