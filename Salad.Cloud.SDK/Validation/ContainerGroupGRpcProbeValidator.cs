namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupGRpcProbeValidator : AbstractValidator<ContainerGroupGRpcProbe?>
{
    public ContainerGroupGRpcProbeValidator()
    {
        RuleFor(ContainerGroupGRpcProbe => ContainerGroupGRpcProbe.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65536)
            .WithMessage("Minimum for port is 65536.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(ContainerGroupGRpcProbe => ContainerGroupGRpcProbe.Service)
            .MaximumLength(1024)
            .WithMessage("Minimum length for service is 0.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for service must match ^.*$.")
            .NotNull()
            .WithMessage("Field service is required.");
    }
}
