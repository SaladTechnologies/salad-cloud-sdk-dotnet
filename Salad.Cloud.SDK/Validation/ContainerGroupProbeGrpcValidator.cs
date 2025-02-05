namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupProbeGrpcValidator : AbstractValidator<ContainerGroupProbeGrpc?>
{
    public ContainerGroupProbeGrpcValidator()
    {
        RuleFor(ContainerGroupProbeGrpc => ContainerGroupProbeGrpc.Service)
            .NotNull()
            .WithMessage("Field service is required.");
        RuleFor(ContainerGroupProbeGrpc => ContainerGroupProbeGrpc.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65536)
            .WithMessage("Minimum for port is 65536.")
            .NotNull()
            .WithMessage("Field port is required.");
    }
}
