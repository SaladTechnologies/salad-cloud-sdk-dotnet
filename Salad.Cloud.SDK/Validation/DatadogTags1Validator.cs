namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class DatadogTags1Validator : AbstractValidator<DatadogTags1?>
{
    public DatadogTags1Validator()
    {
        RuleFor(DatadogTags1 => DatadogTags1.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(DatadogTags1 => DatadogTags1.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
