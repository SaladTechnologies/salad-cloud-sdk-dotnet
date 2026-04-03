namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for CreateContainerGroupNetworking model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class CreateContainerGroupNetworkingValidator
    : AbstractValidator<CreateContainerGroupNetworking>
{
    public CreateContainerGroupNetworkingValidator()
    {
        RuleFor(CreateContainerGroupNetworking => CreateContainerGroupNetworking.Auth)
            .NotNull()
            .WithMessage("Field auth is required and cannot be null.");
        RuleFor(CreateContainerGroupNetworking => CreateContainerGroupNetworking.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
        RuleFor(CreateContainerGroupNetworking => CreateContainerGroupNetworking.Protocol)
            .NotNull()
            .WithMessage("Field protocol is required and cannot be null.");
        RuleFor(CreateContainerGroupNetworking =>
                CreateContainerGroupNetworking.ClientRequestTimeout
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for client_request_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for client_request_timeout is 100000.");

        RuleFor(CreateContainerGroupNetworking =>
                CreateContainerGroupNetworking.ServerResponseTimeout
            )
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for server_response_timeout is 1.")
            .LessThanOrEqualTo(100000)
            .WithMessage("Minimum for server_response_timeout is 100000.");
    }
}
