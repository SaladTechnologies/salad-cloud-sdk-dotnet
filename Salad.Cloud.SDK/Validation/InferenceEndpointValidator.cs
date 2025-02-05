namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class InferenceEndpointValidator : AbstractValidator<InferenceEndpoint?>
{
    public InferenceEndpointValidator()
    {
        RuleFor(InferenceEndpoint => InferenceEndpoint.Id)
            .NotNull()
            .WithMessage("Field id is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Name)
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.")
            .NotNull()
            .WithMessage("Field display_name is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Description)
            .NotNull()
            .WithMessage("Field description is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.EndpointUrl)
            .NotNull()
            .WithMessage("Field endpoint_url is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Readme)
            .NotNull()
            .WithMessage("Field readme is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.PriceDescription)
            .NotNull()
            .WithMessage("Field price_description is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.IconImage)
            .NotNull()
            .WithMessage("Field icon_image is required.");
    }
}
