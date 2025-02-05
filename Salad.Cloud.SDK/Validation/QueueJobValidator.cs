namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueJobValidator : AbstractValidator<QueueJob?>
{
    public QueueJobValidator()
    {
        RuleFor(QueueJob => QueueJob.Id).NotNull().WithMessage("Field id is required.");
        RuleFor(QueueJob => QueueJob.Input_).NotNull().WithMessage("Field input is required.");
        RuleFor(QueueJob => QueueJob.Status).NotNull().WithMessage("Field status is required.");
        RuleFor(QueueJob => QueueJob.Events).NotNull().WithMessage("Field events is required.");
        RuleFor(QueueJob => QueueJob.CreateTime)
            .NotNull()
            .WithMessage("Field create_time is required.");
        RuleFor(QueueJob => QueueJob.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required.");
    }
}
