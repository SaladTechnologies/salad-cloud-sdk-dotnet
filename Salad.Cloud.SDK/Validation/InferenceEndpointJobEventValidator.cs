namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointJobEventValidator : AbstractValidator<InferenceEndpointJobEvent?>
{
    public InferenceEndpointJobEventValidator()
    {
        RuleFor(InferenceEndpointJobEvent => InferenceEndpointJobEvent.Action)
            .NotNull()
            .WithMessage("Field action is required and cannot be null.");
        RuleFor(InferenceEndpointJobEvent => InferenceEndpointJobEvent.Time)
            .NotNull()
            .WithMessage("Field time is required and cannot be null.");
    }
}
