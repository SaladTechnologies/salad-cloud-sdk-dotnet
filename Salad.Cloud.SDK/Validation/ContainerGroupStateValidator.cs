namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupState model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupStateValidator : AbstractValidator<ContainerGroupState>
{
    public ContainerGroupStateValidator()
    {
        RuleFor(ContainerGroupState => ContainerGroupState.FinishTime)
            .NotNull()
            .WithMessage("Field finish_time is required and cannot be null.");
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
            .WithMessage("Field instance_status_counts is required and cannot be null.");
        RuleFor(ContainerGroupState => ContainerGroupState.StartTime)
            .NotNull()
            .WithMessage("Field start_time is required and cannot be null.");
        RuleFor(ContainerGroupState => ContainerGroupState.Status)
            .NotNull()
            .WithMessage("Field status is required and cannot be null.");
        RuleFor(ContainerGroupState => ContainerGroupState.Description)
            .MaximumLength(1000)
            .WithMessage("Minimum length for description is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for description must match ^.*$.");
    }
}
