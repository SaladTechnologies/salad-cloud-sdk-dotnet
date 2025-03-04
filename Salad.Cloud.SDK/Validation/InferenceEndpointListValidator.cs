namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointListValidator : AbstractValidator<InferenceEndpointList?>
{
    public InferenceEndpointListValidator()
    {
        RuleFor(InferenceEndpointList => InferenceEndpointList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
        RuleFor(InferenceEndpointList => InferenceEndpointList.Page)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for page is 1.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for page is 2147483647.")
            .NotNull()
            .WithMessage("Field page is required.");
        RuleFor(InferenceEndpointList => InferenceEndpointList.PageSize)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for page_size is 1.")
            .LessThanOrEqualTo(100)
            .WithMessage("Minimum for page_size is 100.")
            .NotNull()
            .WithMessage("Field page_size is required.");
        RuleFor(InferenceEndpointList => InferenceEndpointList.TotalSize)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for total_size is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for total_size is 2147483647.")
            .NotNull()
            .WithMessage("Field total_size is required.");
    }
}
