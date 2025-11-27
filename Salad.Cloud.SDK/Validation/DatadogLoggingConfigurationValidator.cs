namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class DatadogLoggingConfigurationValidator : AbstractValidator<DatadogLoggingConfiguration?>
{
    public DatadogLoggingConfigurationValidator()
    {
        RuleFor(DatadogLoggingConfiguration => DatadogLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
        RuleFor(DatadogLoggingConfiguration => DatadogLoggingConfiguration.ApiKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_key is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for api_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field api_key is required and cannot be null.");
    }
}
