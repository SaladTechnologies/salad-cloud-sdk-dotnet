namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupCreationRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupCreationRequestValidator
    : AbstractValidator<ContainerGroupCreationRequest>
{
    public ContainerGroupCreationRequestValidator()
    {
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.AutostartPolicy)
            .NotNull()
            .WithMessage("Field autostart_policy is required and cannot be null.");
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.Container)
            .Custom(
                (containerConfiguration, context) =>
                {
                    if (containerConfiguration != null)
                    {
                        var validator = new ContainerConfigurationValidator();
                        var result = validator.Validate(containerConfiguration);
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
            .WithMessage("Field container is required and cannot be null.");
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.")
            .NotNull()
            .WithMessage("Field replicas is required and cannot be null.");
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.RestartPolicy)
            .NotNull()
            .WithMessage("Field restart_policy is required and cannot be null.");

        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.LivenessProbe)
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
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.Networking)
            .Custom(
                (createContainerGroupNetworking, context) =>
                {
                    if (createContainerGroupNetworking != null)
                    {
                        var validator = new CreateContainerGroupNetworkingValidator();
                        var result = validator.Validate(createContainerGroupNetworking);
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
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.QueueAutoscaler)
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
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.QueueConnection)
            .Custom(
                (containerGroupQueueConnection, context) =>
                {
                    if (containerGroupQueueConnection != null)
                    {
                        var validator = new ContainerGroupQueueConnectionValidator();
                        var result = validator.Validate(containerGroupQueueConnection);
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
        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.ReadinessProbe)
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

        RuleFor(ContainerGroupCreationRequest => ContainerGroupCreationRequest.StartupProbe)
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
    }
}
