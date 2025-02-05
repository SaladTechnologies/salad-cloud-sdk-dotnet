namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingHttp3Validator : AbstractValidator<LoggingHttp3?>
{
    public LoggingHttp3Validator()
    {
        RuleFor(LoggingHttp3 => LoggingHttp3.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingHttp3 => LoggingHttp3.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(LoggingHttp3 => LoggingHttp3.Format)
            .NotNull()
            .WithMessage("Field format is required.");
        RuleFor(LoggingHttp3 => LoggingHttp3.Compression)
            .NotNull()
            .WithMessage("Field compression is required.");
    }
}
