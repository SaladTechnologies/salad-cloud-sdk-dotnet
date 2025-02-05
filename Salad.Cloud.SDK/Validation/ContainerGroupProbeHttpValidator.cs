namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupProbeHttpValidator : AbstractValidator<ContainerGroupProbeHttp?>
{
    public ContainerGroupProbeHttpValidator()
    {
        RuleFor(ContainerGroupProbeHttp => ContainerGroupProbeHttp.Path)
            .NotNull()
            .WithMessage("Field path is required.");
        RuleFor(ContainerGroupProbeHttp => ContainerGroupProbeHttp.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65536)
            .WithMessage("Minimum for port is 65536.")
            .NotNull()
            .WithMessage("Field port is required.");
    }
}
