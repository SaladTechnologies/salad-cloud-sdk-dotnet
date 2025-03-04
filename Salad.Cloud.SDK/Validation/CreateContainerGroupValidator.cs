namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateContainerGroupValidator : AbstractValidator<CreateContainerGroup?>
{
    public CreateContainerGroupValidator()
    {
        RuleFor(CreateContainerGroup => CreateContainerGroup.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(CreateContainerGroup => CreateContainerGroup.Container)
            .Custom(
                (createContainer, context) =>
                {
                    if (createContainer != null)
                    {
                        var validator = new CreateContainerValidator();
                        var result = validator.Validate(createContainer);
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
            .WithMessage("Field container is required.");
        RuleFor(CreateContainerGroup => CreateContainerGroup.AutostartPolicy)
            .NotNull()
            .WithMessage("Field autostart_policy is required.");
        RuleFor(CreateContainerGroup => CreateContainerGroup.RestartPolicy)
            .NotNull()
            .WithMessage("Field restart_policy is required.");
        RuleFor(CreateContainerGroup => CreateContainerGroup.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.")
            .NotNull()
            .WithMessage("Field replicas is required.");
        RuleFor(CreateContainerGroup => CreateContainerGroup.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.");

        RuleFor(CreateContainerGroup => CreateContainerGroup.Networking)
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
        RuleFor(CreateContainerGroup => CreateContainerGroup.LivenessProbe)
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
        RuleFor(CreateContainerGroup => CreateContainerGroup.ReadinessProbe)
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
        RuleFor(CreateContainerGroup => CreateContainerGroup.StartupProbe)
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
        RuleFor(CreateContainerGroup => CreateContainerGroup.QueueConnection)
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
        RuleFor(CreateContainerGroup => CreateContainerGroup.QueueAutoscaler)
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
