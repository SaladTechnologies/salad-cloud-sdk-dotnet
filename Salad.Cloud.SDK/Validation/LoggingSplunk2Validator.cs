namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingSplunk2Validator : AbstractValidator<LoggingSplunk2?>
{
    public LoggingSplunk2Validator()
    {
        RuleFor(LoggingSplunk2 => LoggingSplunk2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingSplunk2 => LoggingSplunk2.Token)
            .MinimumLength(1)
            .WithMessage("Minimum length for token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for token is 1.")
            .NotNull()
            .WithMessage("Field token is required.");
    }
}
