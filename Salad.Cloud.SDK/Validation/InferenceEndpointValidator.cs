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
            .WithMessage("Field id is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
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
            .WithMessage("Field organization_name is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.")
            .NotNull()
            .WithMessage("Field display_name is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Description)
            .MaximumLength(1000)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.")
            .NotNull()
            .WithMessage("Field description is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.Readme)
            .MinimumLength(1)
            .WithMessage("Minimum length for readme is 1.")
            .MaximumLength(100000)
            .WithMessage("Minimum length for readme is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for readme must match ^.*$.")
            .NotNull()
            .WithMessage("Field readme is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.PriceDescription)
            .MinimumLength(1)
            .WithMessage("Minimum length for price_description is 1.")
            .MaximumLength(100)
            .WithMessage("Minimum length for price_description is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for price_description must match ^.*$.")
            .NotNull()
            .WithMessage("Field price_description is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.IconUrl)
            .MinimumLength(1)
            .WithMessage("Minimum length for icon_url is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for icon_url is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for icon_url must match ^.*$.")
            .NotNull()
            .WithMessage("Field icon_url is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.InputSchema)
            .MinimumLength(1)
            .WithMessage("Minimum length for input_schema is 1.")
            .MaximumLength(100000)
            .WithMessage("Minimum length for input_schema is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for input_schema must match ^.*$.")
            .NotNull()
            .WithMessage("Field input_schema is required and cannot be null.");
        RuleFor(InferenceEndpoint => InferenceEndpoint.OutputSchema)
            .MinimumLength(1)
            .WithMessage("Minimum length for output_schema is 1.")
            .MaximumLength(100000)
            .WithMessage("Minimum length for output_schema is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for output_schema must match ^.*$.")
            .NotNull()
            .WithMessage("Field output_schema is required and cannot be null.");
    }
}
