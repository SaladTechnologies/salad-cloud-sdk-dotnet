namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for UpdateContainerGroupNetworking model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class UpdateContainerGroupNetworkingValidator
    : AbstractValidator<UpdateContainerGroupNetworking>
{
    public UpdateContainerGroupNetworkingValidator()
    {
        RuleFor(UpdateContainerGroupNetworking => UpdateContainerGroupNetworking.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.");
    }
}
