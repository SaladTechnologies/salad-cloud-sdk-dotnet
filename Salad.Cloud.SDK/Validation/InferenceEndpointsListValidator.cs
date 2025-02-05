namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointsListValidator : AbstractValidator<InferenceEndpointsList?>
{
    public InferenceEndpointsListValidator()
    {
        RuleFor(InferenceEndpointsList => InferenceEndpointsList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
