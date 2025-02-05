namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateQueueValidator : AbstractValidator<UpdateQueue?>
{
    public UpdateQueueValidator()
    {
        RuleFor(UpdateQueue => UpdateQueue.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
        RuleFor(UpdateQueue => UpdateQueue.Description)
            .MaximumLength(500)
            .WithMessage("Minimum length for description is 0.");
    }
}
