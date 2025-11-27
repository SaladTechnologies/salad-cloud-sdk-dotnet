namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueCollectionValidator : AbstractValidator<QueueCollection?>
{
    public QueueCollectionValidator()
    {
        RuleFor(QueueCollection => QueueCollection.Items)
            .NotNull()
            .WithMessage("Field items is required and cannot be null.");
    }
}
