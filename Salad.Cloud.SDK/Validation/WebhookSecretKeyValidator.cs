namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class WebhookSecretKeyValidator : AbstractValidator<WebhookSecretKey?>
{
    public WebhookSecretKeyValidator()
    {
        RuleFor(WebhookSecretKey => WebhookSecretKey.SecretKey)
            .MinimumLength(44)
            .WithMessage("Minimum length for secret_key is 44.")
            .MaximumLength(172)
            .WithMessage("Minimum length for secret_key is 44.")
            .Matches(@"^[+/=0-9A-Za-z]{44,172}$")
            .WithMessage(@"Pattern for secret_key must match ^[+/=0-9A-Za-z]{44,172}$.")
            .NotNull()
            .WithMessage("Field secret_key is required.");
    }
}
