namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupNetworkingConfigurationValidator
    : AbstractValidator<ContainerGroupNetworkingConfiguration?>
{
    public ContainerGroupNetworkingConfigurationValidator()
    {
        RuleFor(ContainerGroupNetworkingConfiguration => ContainerGroupNetworkingConfiguration.Auth)
            .NotNull()
            .WithMessage("Field auth is required and cannot be null.");
        RuleFor(ContainerGroupNetworkingConfiguration => ContainerGroupNetworkingConfiguration.Dns)
            .MinimumLength(1)
            .WithMessage("Minimum length for dns is 1.")
            .MaximumLength(253)
            .WithMessage("Minimum length for dns is 1.")
            .Matches(@"^([a-z][a-z0-9-]{0,61}[a-z0-9]\.)*[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(
                @"Pattern for dns must match ^([a-z][a-z0-9-]{0,61}[a-z0-9]\.)*[a-z][a-z0-9-]{0,61}[a-z0-9]$."
            )
            .NotNull()
            .WithMessage("Field dns is required and cannot be null.");
        RuleFor(ContainerGroupNetworkingConfiguration =>
                ContainerGroupNetworkingConfiguration.LoadBalancer
            )
            .NotNull()
            .WithMessage("Field load_balancer is required and cannot be null.");
        RuleFor(ContainerGroupNetworkingConfiguration => ContainerGroupNetworkingConfiguration.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
        RuleFor(ContainerGroupNetworkingConfiguration =>
                ContainerGroupNetworkingConfiguration.Protocol
            )
            .NotNull()
            .WithMessage("Field protocol is required and cannot be null.");
        RuleFor(ContainerGroupNetworkingConfiguration =>
                ContainerGroupNetworkingConfiguration.ClientRequestTimeout
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for client_request_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for client_request_timeout is 100000.");
        RuleFor(ContainerGroupNetworkingConfiguration =>
                ContainerGroupNetworkingConfiguration.ServerResponseTimeout
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for server_response_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for server_response_timeout is 100000.");
    }
}
