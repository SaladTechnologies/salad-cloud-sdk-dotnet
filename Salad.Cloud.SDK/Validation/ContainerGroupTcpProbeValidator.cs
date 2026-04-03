namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupTcpProbe model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupTcpProbeValidator : AbstractValidator<ContainerGroupTcpProbe>
{
    public ContainerGroupTcpProbeValidator()
    {
        RuleFor(ContainerGroupTcpProbe => ContainerGroupTcpProbe.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
    }
}
