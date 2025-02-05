namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueJobListValidator : AbstractValidator<QueueJobList?>
{
    public QueueJobListValidator()
    {
        RuleFor(QueueJobList => QueueJobList.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
