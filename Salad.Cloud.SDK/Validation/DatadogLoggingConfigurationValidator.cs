namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for DatadogLoggingConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class DatadogLoggingConfigurationValidator : AbstractValidator<DatadogLoggingConfiguration>
{
    public DatadogLoggingConfigurationValidator()
    {
        RuleFor(DatadogLoggingConfiguration => DatadogLoggingConfiguration.ApiKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_key is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for api_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field api_key is required and cannot be null.");
        RuleFor(DatadogLoggingConfiguration => DatadogLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
    }
}
