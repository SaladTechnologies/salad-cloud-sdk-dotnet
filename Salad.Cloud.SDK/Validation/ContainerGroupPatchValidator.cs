namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupPatchValidator : AbstractValidator<ContainerGroupPatch?>
{
    public ContainerGroupPatchValidator()
    {
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.Container)
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
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.");

        RuleFor(ContainerGroupPatch => ContainerGroupPatch.Networking)
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
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.LivenessProbe)
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
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.ReadinessProbe)
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
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.StartupProbe)
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
        RuleFor(ContainerGroupPatch => ContainerGroupPatch.QueueAutoscaler)
            .Custom(
                (queueBasedAutoscalerConfiguration, context) =>
                {
                    if (queueBasedAutoscalerConfiguration != null)
                    {
                        var validator = new QueueBasedAutoscalerConfigurationValidator();
                        var result = validator.Validate(queueBasedAutoscalerConfiguration);
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
