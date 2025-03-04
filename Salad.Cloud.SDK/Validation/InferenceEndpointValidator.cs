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
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.OrganizationName)
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
            .MaximumLength(1000)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^[\P{Cc}\P{Cn}\P{Cs}]*$")
            .WithMessage(@"Pattern for description must match ^[\P{Cc}\P{Cn}\P{Cs}]*$.")
            .NotNull()
            .WithMessage("Field description is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Readme)
            .NotNull()
            .WithMessage("Field readme is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.PriceDescription)
            .NotNull()
            .WithMessage("Field price_description is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.IconUrl)
            .NotNull()
            .WithMessage("Field icon_url is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.InputSchema)
            .NotNull()
            .WithMessage("Field input_schema is required.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.OutputSchema)
            .NotNull()
            .WithMessage("Field output_schema is required.");
    }
}
