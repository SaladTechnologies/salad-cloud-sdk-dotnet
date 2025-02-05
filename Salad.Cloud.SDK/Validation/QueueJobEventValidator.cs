namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueJobEventValidator : AbstractValidator<QueueJobEvent?>
{
    public QueueJobEventValidator()
    {
        RuleFor(QueueJobEvent => QueueJobEvent.Action)
            .NotNull()
            .WithMessage("Field action is required.");
        RuleFor(QueueJobEvent => QueueJobEvent.Time)
            .NotNull()
            .WithMessage("Field time is required.");
    }
}
