namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointJobValidator : AbstractValidator<InferenceEndpointJob?>
{
    public InferenceEndpointJobValidator()
    {
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Id)
            .NotNull()
            .WithMessage("Field id is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.InferenceEndpointName)
            .MinimumLength(2)
            .WithMessage("Minimum length for inference_endpoint_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for inference_endpoint_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(
                @"Pattern for inference_endpoint_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$."
            )
            .NotNull()
            .WithMessage("Field inference_endpoint_name is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.OrganizationName)
            .MinimumLength(2)
            .WithMessage("Minimum length for organization_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for organization_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(
                @"Pattern for organization_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$."
            )
            .NotNull()
            .WithMessage("Field organization_name is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Input_)
            .NotNull()
            .WithMessage("Field input is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Status)
            .NotNull()
            .WithMessage("Field status is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Events)
            .NotNull()
            .WithMessage("Field events is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.CreateTime)
            .NotNull()
            .WithMessage("Field create_time is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required.");

        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Webhook)
            .MinimumLength(1)
            .WithMessage("Minimum length for webhook is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for webhook is 1.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.WebhookUrl)
            .MinimumLength(1)
            .WithMessage("Minimum length for webhook_url is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for webhook_url is 1.");
    }
}
