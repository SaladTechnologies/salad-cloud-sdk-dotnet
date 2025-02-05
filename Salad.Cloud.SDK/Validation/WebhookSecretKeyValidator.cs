namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class WebhookSecretKeyValidator : AbstractValidator<WebhookSecretKey?>
{
    public WebhookSecretKeyValidator()
    {
        RuleFor(WebhookSecretKey => WebhookSecretKey.SecretKey)
            .NotNull()
            .WithMessage("Field secret_key is required.");
    }
}
