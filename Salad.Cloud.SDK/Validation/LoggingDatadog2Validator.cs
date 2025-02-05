namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingDatadog2Validator : AbstractValidator<LoggingDatadog2?>
{
    public LoggingDatadog2Validator()
    {
        RuleFor(LoggingDatadog2 => LoggingDatadog2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingDatadog2 => LoggingDatadog2.ApiKey)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_key is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_key is 1.")
            .NotNull()
            .WithMessage("Field api_key is required.");
    }
}
