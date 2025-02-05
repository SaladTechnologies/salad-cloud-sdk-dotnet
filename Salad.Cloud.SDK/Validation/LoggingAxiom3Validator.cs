namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LoggingAxiom3Validator : AbstractValidator<LoggingAxiom3?>
{
    public LoggingAxiom3Validator()
    {
        RuleFor(LoggingAxiom3 => LoggingAxiom3.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(LoggingAxiom3 => LoggingAxiom3.ApiToken)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_token is 1.")
            .NotNull()
            .WithMessage("Field api_token is required.");
        RuleFor(LoggingAxiom3 => LoggingAxiom3.Dataset)
            .MinimumLength(1)
            .WithMessage("Minimum length for dataset is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for dataset is 1.")
            .NotNull()
            .WithMessage("Field dataset is required.");
    }
}
