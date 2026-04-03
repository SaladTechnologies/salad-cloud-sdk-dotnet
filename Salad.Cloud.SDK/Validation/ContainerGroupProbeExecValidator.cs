namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupProbeExec model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupProbeExecValidator : AbstractValidator<ContainerGroupProbeExec>
{
    public ContainerGroupProbeExecValidator()
    {
        RuleFor(ContainerGroupProbeExec => ContainerGroupProbeExec.Command)
            .NotNull()
            .WithMessage("Field command is required and cannot be null.");
    }
}
