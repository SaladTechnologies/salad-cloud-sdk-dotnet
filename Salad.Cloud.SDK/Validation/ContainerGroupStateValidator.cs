namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupStateValidator : AbstractValidator<ContainerGroupState?>
{
    public ContainerGroupStateValidator()
    {
        RuleFor(ContainerGroupState => ContainerGroupState.FinishTime)
            .NotNull()
            .WithMessage("Field finish_time is required.");
        RuleFor(ContainerGroupState => ContainerGroupState.InstanceStatusCounts)
            .Custom(
                (containerGroupInstanceStatusCount, context) =>
                {
                    if (containerGroupInstanceStatusCount != null)
                    {
                        var validator = new ContainerGroupInstanceStatusCountValidator();
                        var result = validator.Validate(containerGroupInstanceStatusCount);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            )
            .NotNull()
            .WithMessage("Field instance_status_counts is required.");
        RuleFor(ContainerGroupState => ContainerGroupState.StartTime)
            .NotNull()
            .WithMessage("Field start_time is required.");
        RuleFor(ContainerGroupState => ContainerGroupState.Status)
            .NotNull()
            .WithMessage("Field status is required.");
        RuleFor(ContainerGroupState => ContainerGroupState.Description)
            .MaximumLength(1000)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.");
    }
}
