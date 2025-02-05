namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingNewRelic1Validator : AbstractValidator<LoggingNewRelic1?>
{
    public LoggingNewRelic1Validator()
    {
        RuleFor(LoggingNewRelic1 => LoggingNewRelic1.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingNewRelic1 => LoggingNewRelic1.IngestionKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .NotNull()
            .WithMessage("Field ingestion_key is required.");
    }
}
