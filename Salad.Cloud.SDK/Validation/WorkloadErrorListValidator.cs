namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class WorkloadErrorListValidator : AbstractValidator<WorkloadErrorList?>
{
    public WorkloadErrorListValidator()
    {
        RuleFor(WorkloadErrorList => WorkloadErrorList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
