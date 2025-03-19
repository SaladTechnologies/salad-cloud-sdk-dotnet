namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class QueueValidator : AbstractValidator<Queue?>
{
    public QueueValidator()
    {
        RuleFor(Queue => Queue.Id).NotNull().WithMessage("Field id is required.");
        RuleFor(Queue => Queue.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(Queue => Queue.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.")
            .NotNull()
            .WithMessage("Field display_name is required.");
        RuleFor(Queue => Queue.ContainerGroups)
            .NotNull()
            .WithMessage("Field container_groups is required.");
        RuleFor(Queue => Queue.CreateTime).NotNull().WithMessage("Field create_time is required.");
        RuleFor(Queue => Queue.UpdateTime).NotNull().WithMessage("Field update_time is required.");
        RuleFor(Queue => Queue.Description)
            .MaximumLength(500)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.");
    }
}
