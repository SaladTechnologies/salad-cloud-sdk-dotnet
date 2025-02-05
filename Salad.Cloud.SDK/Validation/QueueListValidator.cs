namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueListValidator : AbstractValidator<QueueList?>
{
    public QueueListValidator()
    {
        RuleFor(QueueList => QueueList.Items).NotNull().WithMessage("Field items is required.");
    }
}
