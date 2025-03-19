namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupValidator : AbstractValidator<ContainerGroup?>
{
    public ContainerGroupValidator()
    {
        RuleFor(ContainerGroup => ContainerGroup.AutostartPolicy)
            .NotNull()
            .WithMessage("Field autostart_policy is required.");
        RuleFor(ContainerGroup => ContainerGroup.Container)
            .Custom(
                (container, context) =>
                {
                    if (container != null)
                    {
                        var validator = new ContainerValidator();
                        var result = validator.Validate(container);
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
        RuleFor(ContainerGroup => ContainerGroup.CountryCodes)
            .NotNull()
            .WithMessage("Field country_codes is required.");
        RuleFor(ContainerGroup => ContainerGroup.CreateTime)
            .NotNull()
            .WithMessage("Field create_time is required.");
        RuleFor(ContainerGroup => ContainerGroup.CurrentState)
            .Custom(
                (containerGroupState, context) =>
                {
                    if (containerGroupState != null)
                    {
                        var validator = new ContainerGroupStateValidator();
                        var result = validator.Validate(containerGroupState);
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
            .WithMessage("Field current_state is required.");
        RuleFor(ContainerGroup => ContainerGroup.DisplayName)
            .MinimumLength(2)
            .WithMessage("Minimum length for display_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for display_name is 2.")
            .Matches(@"^[ ,-.0-9A-Za-z]+$")
            .WithMessage(@"Pattern for display_name must match ^[ ,-.0-9A-Za-z]+$.")
            .NotNull()
            .WithMessage("Field display_name is required.");
        RuleFor(ContainerGroup => ContainerGroup.Id).NotNull().WithMessage("Field id is required.");
        RuleFor(ContainerGroup => ContainerGroup.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(ContainerGroup => ContainerGroup.OrganizationName)
            .MinimumLength(2)
            .WithMessage("Minimum length for organization_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for organization_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(
                @"Pattern for organization_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$."
            )
            .NotNull()
            .WithMessage("Field organization_name is required.");
        RuleFor(ContainerGroup => ContainerGroup.PendingChange)
            .NotNull()
            .WithMessage("Field pending_change is required.");
        RuleFor(ContainerGroup => ContainerGroup.Priority)
            .NotNull()
            .WithMessage("Field priority is required.");
        RuleFor(ContainerGroup => ContainerGroup.ProjectName)
            .MinimumLength(2)
            .WithMessage("Minimum length for project_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for project_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for project_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field project_name is required.");
        RuleFor(ContainerGroup => ContainerGroup.Replicas)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for replicas is 0.")
            .LessThanOrEqualTo(500)
            .WithMessage("Minimum for replicas is 500.")
            .NotNull()
            .WithMessage("Field replicas is required.");
        RuleFor(ContainerGroup => ContainerGroup.RestartPolicy)
            .NotNull()
            .WithMessage("Field restart_policy is required.");
        RuleFor(ContainerGroup => ContainerGroup.UpdateTime)
            .NotNull()
            .WithMessage("Field update_time is required.");
        RuleFor(ContainerGroup => ContainerGroup.Version)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for version is 1.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for version is 2147483647.")
            .NotNull()
            .WithMessage("Field version is required.");
        RuleFor(ContainerGroup => ContainerGroup.LivenessProbe)
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
        RuleFor(ContainerGroup => ContainerGroup.Networking)
            .Custom(
                (containerGroupNetworkingConfiguration, context) =>
                {
                    if (containerGroupNetworkingConfiguration != null)
                    {
                        var validator = new ContainerGroupNetworkingConfigurationValidator();
                        var result = validator.Validate(containerGroupNetworkingConfiguration);
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
        RuleFor(ContainerGroup => ContainerGroup.QueueAutoscaler)
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
        RuleFor(ContainerGroup => ContainerGroup.QueueConnection)
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
        RuleFor(ContainerGroup => ContainerGroup.ReadinessProbe)
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
        RuleFor(ContainerGroup => ContainerGroup.StartupProbe)
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
