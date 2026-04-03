namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for NewRelicLoggingConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class NewRelicLoggingConfigurationValidator : AbstractValidator<NewRelicLoggingConfiguration>
{
    public NewRelicLoggingConfigurationValidator()
    {
        RuleFor(NewRelicLoggingConfiguration => NewRelicLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
        RuleFor(NewRelicLoggingConfiguration => NewRelicLoggingConfiguration.IngestionKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for ingestion_key must match ^.*$.")
            .NotNull()
            .WithMessage("Field ingestion_key is required and cannot be null.");
    }
}
