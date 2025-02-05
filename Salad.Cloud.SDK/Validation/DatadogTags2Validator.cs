namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class DatadogTags2Validator : AbstractValidator<DatadogTags2?>
{
    public DatadogTags2Validator()
    {
        RuleFor(DatadogTags2 => DatadogTags2.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(DatadogTags2 => DatadogTags2.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
