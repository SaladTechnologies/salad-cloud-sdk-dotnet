namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class DatadogTags3Validator : AbstractValidator<DatadogTags3?>
{
    public DatadogTags3Validator()
    {
        RuleFor(DatadogTags3 => DatadogTags3.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(DatadogTags3 => DatadogTags3.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
