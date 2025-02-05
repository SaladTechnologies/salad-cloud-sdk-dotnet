namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointJobListValidator : AbstractValidator<InferenceEndpointJobList?>
{
    public InferenceEndpointJobListValidator()
    {
        RuleFor(InferenceEndpointJobList => InferenceEndpointJobList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
