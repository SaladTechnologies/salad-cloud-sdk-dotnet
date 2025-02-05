namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingHttp2Validator : AbstractValidator<LoggingHttp2?>
{
    public LoggingHttp2Validator()
    {
        RuleFor(LoggingHttp2 => LoggingHttp2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingHttp2 => LoggingHttp2.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(LoggingHttp2 => LoggingHttp2.Format)
            .NotNull()
            .WithMessage("Field format is required.");
        RuleFor(LoggingHttp2 => LoggingHttp2.Compression)
            .NotNull()
            .WithMessage("Field compression is required.");
    }
}
