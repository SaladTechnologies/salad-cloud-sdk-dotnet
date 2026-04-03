namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupProbeHttpHeader model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupProbeHttpHeaderValidator
    : AbstractValidator<ContainerGroupProbeHttpHeader>
{
    public ContainerGroupProbeHttpHeaderValidator()
    {
        RuleFor(ContainerGroupProbeHttpHeader => ContainerGroupProbeHttpHeader.Name)
            .MinimumLength(1)
            .WithMessage("Minimum length for name is 1.")
            .MaximumLength(256)
            .WithMessage("Minimum length for name is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for name must match ^.*$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(ContainerGroupProbeHttpHeader => ContainerGroupProbeHttpHeader.Value)
            .MinimumLength(1)
            .WithMessage("Minimum length for value is 1.")
            .MaximumLength(1024)
            .WithMessage("Minimum length for value is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for value must match ^.*$.")
            .NotNull()
            .WithMessage("Field value is required and cannot be null.");
    }
}
