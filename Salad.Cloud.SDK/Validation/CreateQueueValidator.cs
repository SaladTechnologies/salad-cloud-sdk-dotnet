namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateQueueValidator : AbstractValidator<CreateQueue?>
{
    public CreateQueueValidator()
    {
        RuleFor(CreateQueue => CreateQueue.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(CreateQueue => CreateQueue.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
        RuleFor(CreateQueue => CreateQueue.Description)
            .MaximumLength(500)
            .WithMessage("Minimum length for description is 0.");
    }
}
