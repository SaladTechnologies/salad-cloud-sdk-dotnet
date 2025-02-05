namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingNewRelic2Validator : AbstractValidator<LoggingNewRelic2?>
{
    public LoggingNewRelic2Validator()
    {
        RuleFor(LoggingNewRelic2 => LoggingNewRelic2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingNewRelic2 => LoggingNewRelic2.IngestionKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for ingestion_key is 1.")
            .NotNull()
            .WithMessage("Field ingestion_key is required.");
    }
}
