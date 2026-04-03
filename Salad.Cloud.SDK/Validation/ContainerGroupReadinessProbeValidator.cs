namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupReadinessProbe model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupReadinessProbeValidator : AbstractValidator<ContainerGroupReadinessProbe>
{
    public ContainerGroupReadinessProbeValidator()
    {
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.FailureThreshold)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for failure_threshold is 1.")
            .LessThanOrEqualTo(20)
            .WithMessage("Minimum for failure_threshold is 20.")
            .NotNull()
            .WithMessage("Field failure_threshold is required and cannot be null.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.InitialDelaySeconds)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for initial_delay_seconds is 0.")
            .LessThanOrEqualTo(1200)
            .WithMessage("Minimum for initial_delay_seconds is 1200.")
            .NotNull()
            .WithMessage("Field initial_delay_seconds is required and cannot be null.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.PeriodSeconds)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for period_seconds is 1.")
            .LessThanOrEqualTo(120)
            .WithMessage("Minimum for period_seconds is 120.")
            .NotNull()
            .WithMessage("Field period_seconds is required and cannot be null.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.SuccessThreshold)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for success_threshold is 1.")
            .LessThanOrEqualTo(10)
            .WithMessage("Minimum for success_threshold is 10.")
            .NotNull()
            .WithMessage("Field success_threshold is required and cannot be null.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.TimeoutSeconds)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for timeout_seconds is 1.")
            .LessThanOrEqualTo(60)
            .WithMessage("Minimum for timeout_seconds is 60.")
            .NotNull()
            .WithMessage("Field timeout_seconds is required and cannot be null.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.Exec)
            .Custom(
                (containerGroupProbeExec, context) =>
                {
                    if (containerGroupProbeExec != null)
                    {
                        var validator = new ContainerGroupProbeExecValidator();
                        var result = validator.Validate(containerGroupProbeExec);
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
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.Grpc)
            .Custom(
                (containerGroupGRpcProbe, context) =>
                {
                    if (containerGroupGRpcProbe != null)
                    {
                        var validator = new ContainerGroupGRpcProbeValidator();
                        var result = validator.Validate(containerGroupGRpcProbe);
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
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.Http)
            .Custom(
                (containerGroupHttpProbeConfiguration, context) =>
                {
                    if (containerGroupHttpProbeConfiguration != null)
                    {
                        var validator = new ContainerGroupHttpProbeConfigurationValidator();
                        var result = validator.Validate(containerGroupHttpProbeConfiguration);
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
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.Tcp)
            .Custom(
                (containerGroupTcpProbe, context) =>
                {
                    if (containerGroupTcpProbe != null)
                    {
                        var validator = new ContainerGroupTcpProbeValidator();
                        var result = validator.Validate(containerGroupTcpProbe);
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
