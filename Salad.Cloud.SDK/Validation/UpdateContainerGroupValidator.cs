namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateContainerGroupValidator : AbstractValidator<UpdateContainerGroup?>
{
    public UpdateContainerGroupValidator()
    {
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.Container)
            .Custom(
                (updateContainer, context) =>
                {
                    if (updateContainer != null)
                    {
                        var validator = new UpdateContainerValidator();
                        var result = validator.Validate(updateContainer);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.");

        RuleFor(UpdateContainerGroup => UpdateContainerGroup.Networking)
            .Custom(
                (updateContainerGroupNetworking, context) =>
                {
                    if (updateContainerGroupNetworking != null)
                    {
                        var validator = new UpdateContainerGroupNetworkingValidator();
                        var result = validator.Validate(updateContainerGroupNetworking);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.LivenessProbe)
            .Custom(
                (containerGroupLivenessProbe, context) =>
                {
                    if (containerGroupLivenessProbe != null)
                    {
                        var validator = new ContainerGroupLivenessProbeValidator();
                        var result = validator.Validate(containerGroupLivenessProbe);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.ReadinessProbe)
            .Custom(
                (containerGroupReadinessProbe, context) =>
                {
                    if (containerGroupReadinessProbe != null)
                    {
                        var validator = new ContainerGroupReadinessProbeValidator();
                        var result = validator.Validate(containerGroupReadinessProbe);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.StartupProbe)
            .Custom(
                (containerGroupStartupProbe, context) =>
                {
                    if (containerGroupStartupProbe != null)
                    {
                        var validator = new ContainerGroupStartupProbeValidator();
                        var result = validator.Validate(containerGroupStartupProbe);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(UpdateContainerGroup => UpdateContainerGroup.QueueAutoscaler)
            .Custom(
                (queueAutoscaler, context) =>
                {
                    if (queueAutoscaler != null)
                    {
                        var validator = new QueueAutoscalerValidator();
                        var result = validator.Validate(queueAutoscaler);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
    }
}
