namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupProbeHttpHeaders2Validator
    : AbstractValidator<ContainerGroupProbeHttpHeaders2?>
{
    public ContainerGroupProbeHttpHeaders2Validator()
    {
        RuleFor(ContainerGroupProbeHttpHeaders2 => ContainerGroupProbeHttpHeaders2.Name)
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(ContainerGroupProbeHttpHeaders2 => ContainerGroupProbeHttpHeaders2.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
