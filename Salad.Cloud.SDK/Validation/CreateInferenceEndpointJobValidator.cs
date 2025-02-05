namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateInferenceEndpointJobValidator : AbstractValidator<CreateInferenceEndpointJob?>
{
    public CreateInferenceEndpointJobValidator()
    {
        RuleFor(CreateInferenceEndpointJob => CreateInferenceEndpointJob.Input_)
            .NotNull()
            .WithMessage("Field input is required.");

        RuleFor(CreateInferenceEndpointJob => CreateInferenceEndpointJob.Webhook)
            .MaximumLength(2000)
            .WithMessage("Minimum length for webhook is undefined.");
    }
}
