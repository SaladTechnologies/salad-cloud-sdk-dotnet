namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class SystemLogListValidator : AbstractValidator<SystemLogList?>
{
    public SystemLogListValidator()
    {
        RuleFor(SystemLogList => SystemLogList.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
    }
}
