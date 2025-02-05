namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingDatadog3Validator : AbstractValidator<LoggingDatadog3?>
{
    public LoggingDatadog3Validator()
    {
        RuleFor(LoggingDatadog3 => LoggingDatadog3.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingDatadog3 => LoggingDatadog3.ApiKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_key is 1.")
            .NotNull()
            .WithMessage("Field api_key is required.");
    }
}
