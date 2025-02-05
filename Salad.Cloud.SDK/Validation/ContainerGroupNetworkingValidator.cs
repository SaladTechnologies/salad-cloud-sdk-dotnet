namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupNetworkingValidator : AbstractValidator<ContainerGroupNetworking?>
{
    public ContainerGroupNetworkingValidator()
    {
        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.Protocol)
            .NotNull()
            .WithMessage("Field protocol is required.");
        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.Auth)
            .NotNull()
            .WithMessage("Field auth is required.");
        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.Dns)
            .NotNull()
            .WithMessage("Field dns is required.");

        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.ClientRequestTimeout)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for client_request_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for client_request_timeout is 100000.");
        RuleFor(ContainerGroupNetworking => ContainerGroupNetworking.ServerResponseTimeout)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for server_response_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for server_response_timeout is 100000.");
    }
}
