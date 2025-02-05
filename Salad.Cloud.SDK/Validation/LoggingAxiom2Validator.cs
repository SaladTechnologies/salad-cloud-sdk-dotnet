namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingAxiom2Validator : AbstractValidator<LoggingAxiom2?>
{
    public LoggingAxiom2Validator()
    {
        RuleFor(LoggingAxiom2 => LoggingAxiom2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingAxiom2 => LoggingAxiom2.ApiToken)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_token is 1.")
            .NotNull()
            .WithMessage("Field api_token is required.");
        RuleFor(LoggingAxiom2 => LoggingAxiom2.Dataset)
            .MinimumLength(1)
            .WithMessage("Minimum length for dataset is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for dataset is 1.")
            .NotNull()
            .WithMessage("Field dataset is required.");
    }
}
