namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateQueueJobValidator : AbstractValidator<CreateQueueJob?>
{
    public CreateQueueJobValidator()
    {
        RuleFor(CreateQueueJob => CreateQueueJob.Input_)
            .NotNull()
            .WithMessage("Field input is required.");
    }
}
