namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueJobCollectionValidator : AbstractValidator<QueueJobCollection?>
{
    public QueueJobCollectionValidator()
    {
        RuleFor(QueueJobCollection => QueueJobCollection.Items)
            .NotNull()
            .WithMessage("Field items is required.");
    }
}
