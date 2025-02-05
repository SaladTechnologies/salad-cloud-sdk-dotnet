namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupReadinessProbeValidator
    : AbstractValidator<ContainerGroupReadinessProbe?>
{
    public ContainerGroupReadinessProbeValidator()
    {
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.InitialDelaySeconds)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for initial_delay_seconds is 0.")
            .NotNull()
            .WithMessage("Field initial_delay_seconds is required.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.PeriodSeconds)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for period_seconds is 1.")
            .NotNull()
            .WithMessage("Field period_seconds is required.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.TimeoutSeconds)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for timeout_seconds is 1.")
            .NotNull()
            .WithMessage("Field timeout_seconds is required.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.SuccessThreshold)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for success_threshold is 1.")
            .NotNull()
            .WithMessage("Field success_threshold is required.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.FailureThreshold)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for failure_threshold is 1.")
            .NotNull()
            .WithMessage("Field failure_threshold is required.");
        RuleFor(ContainerGroupReadinessProbe => ContainerGroupReadinessProbe.Tcp)
            .Custom(
                (containerGroupProbeTcp, context) =>
                {
                    if (containerGroupProbeTcp != null)
                    {
                        var validator = new ContainerGroupProbeTcpValidator();
                        var result = validator.Validate(containerGroupProbeTcp);
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
                (containerGroupProbeHttp, context) =>
                {
                    if (containerGroupProbeHttp != null)
                    {
                        var validator = new ContainerGroupProbeHttpValidator();
                        var result = validator.Validate(containerGroupProbeHttp);
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
                (containerGroupProbeGrpc, context) =>
                {
                    if (containerGroupProbeGrpc != null)
                    {
                        var validator = new ContainerGroupProbeGrpcValidator();
                        var result = validator.Validate(containerGroupProbeGrpc);
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
    }
}
