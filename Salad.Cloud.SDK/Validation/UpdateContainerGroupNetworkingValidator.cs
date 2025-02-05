namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateContainerGroupNetworkingValidator
    : AbstractValidator<UpdateContainerGroupNetworking?>
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
