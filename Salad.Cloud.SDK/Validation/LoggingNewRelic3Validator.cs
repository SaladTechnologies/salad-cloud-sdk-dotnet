namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingNewRelic3Validator : AbstractValidator<LoggingNewRelic3?>
{
    public LoggingNewRelic3Validator()
    {
        RuleFor(LoggingNewRelic3 => LoggingNewRelic3.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingNewRelic3 => LoggingNewRelic3.IngestionKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .NotNull()
            .WithMessage("Field ingestion_key is required.");
    }
}
