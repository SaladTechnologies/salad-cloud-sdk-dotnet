namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class WebhookSecretKeyValidator : AbstractValidator<WebhookSecretKey?>
{
    public WebhookSecretKeyValidator()
    {
        RuleFor(WebhookSecretKey => WebhookSecretKey.SecretKey)
            .MinimumLength(8)
            .WithMessage("Minimum length for secret_key is 8.")
            .MaximumLength(64)
            .WithMessage("Minimum length for secret_key is 8.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for secret_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field secret_key is required.");
    }
}
