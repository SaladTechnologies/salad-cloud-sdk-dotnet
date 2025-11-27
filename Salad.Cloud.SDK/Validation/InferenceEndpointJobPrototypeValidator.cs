namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointJobPrototypeValidator
    : AbstractValidator<InferenceEndpointJobPrototype?>
{
    public InferenceEndpointJobPrototypeValidator()
    {
        RuleFor(InferenceEndpointJobPrototype => InferenceEndpointJobPrototype.Input_)
            .NotNull()
            .WithMessage("Field input is required and cannot be null.");

        RuleFor(InferenceEndpointJobPrototype => InferenceEndpointJobPrototype.Webhook)
            .MinimumLength(1)
            .WithMessage("Minimum length for webhook is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for webhook is 1.");
        RuleFor(InferenceEndpointJobPrototype => InferenceEndpointJobPrototype.WebhookUrl)
            .MinimumLength(1)
            .WithMessage("Minimum length for webhook_url is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for webhook_url is 1.");
    }
}
