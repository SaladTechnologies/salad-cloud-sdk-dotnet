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
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Input_)
            .NotNull()
            .WithMessage("Field input is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.InferenceEndpointName)
            .NotNull()
            .WithMessage("Field inference_endpoint_name is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Status)
            .NotNull()
            .WithMessage("Field status is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.Events)
            .NotNull()
            .WithMessage("Field events is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.OrganizationName)
            .NotNull()
            .WithMessage("Field organization_name is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.CreateTime)
            .NotNull()
            .WithMessage("Field create_time is required.");
        RuleFor(InferenceEndpointJob => InferenceEndpointJob.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required.");
    }
}
