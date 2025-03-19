namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupTcpProbeValidator : AbstractValidator<ContainerGroupTcpProbe?>
{
    public ContainerGroupTcpProbeValidator()
    {
        RuleFor(ContainerGroupTcpProbe => ContainerGroupTcpProbe.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
    }
}
