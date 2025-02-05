namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupProbeExecValidator : AbstractValidator<ContainerGroupProbeExec?>
{
    public ContainerGroupProbeExecValidator()
    {
        RuleFor(ContainerGroupProbeExec => ContainerGroupProbeExec.Command)
            .NotNull()
            .WithMessage("Field command is required.");
    }
}
