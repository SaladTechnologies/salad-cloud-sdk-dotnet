namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class DatadogTagForContainerLoggingValidator
    : AbstractValidator<DatadogTagForContainerLogging?>
{
    public DatadogTagForContainerLoggingValidator()
    {
        RuleFor(DatadogTagForContainerLogging => DatadogTagForContainerLogging.Name)
            .MinimumLength(1)
            .WithMessage("Minimum length for name is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for name is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for name must match ^.*$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(DatadogTagForContainerLogging => DatadogTagForContainerLogging.Value)
            .MinimumLength(1)
            .WithMessage("Minimum length for value is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for value is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for value must match ^.*$.")
            .NotNull()
            .WithMessage("Field value is required and cannot be null.");
    }
}
