namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerLoggingSplunkConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerLoggingSplunkConfigurationValidator
    : AbstractValidator<ContainerLoggingSplunkConfiguration>
{
    public ContainerLoggingSplunkConfigurationValidator()
    {
        RuleFor(ContainerLoggingSplunkConfiguration => ContainerLoggingSplunkConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
        RuleFor(ContainerLoggingSplunkConfiguration => ContainerLoggingSplunkConfiguration.Token)
            .MinimumLength(1)
            .WithMessage("Minimum length for token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for token is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for token must match ^.*$.")
            .NotNull()
            .WithMessage("Field token is required and cannot be null.");
    }
}
