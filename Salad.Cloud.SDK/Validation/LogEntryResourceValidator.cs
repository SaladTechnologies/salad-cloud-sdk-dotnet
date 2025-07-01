namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LogEntryResourceValidator : AbstractValidator<LogEntryResource?>
{
    public LogEntryResourceValidator()
    {
        RuleFor(LogEntryResource => LogEntryResource.Labels)
            .NotNull()
            .WithMessage("Field labels is required.");
        RuleFor(LogEntryResource => LogEntryResource.Type_)
            .MinimumLength(1)
            .WithMessage("Minimum length for type is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for type is 1.")
            .NotNull()
            .WithMessage("Field type is required.");
    }
}
