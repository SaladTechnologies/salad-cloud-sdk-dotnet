namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerGroupQueueConnection model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerGroupQueueConnectionValidator
    : AbstractValidator<ContainerGroupQueueConnection>
{
    public ContainerGroupQueueConnectionValidator()
    {
        RuleFor(ContainerGroupQueueConnection => ContainerGroupQueueConnection.Path)
            .MinimumLength(1)
            .WithMessage("Minimum length for path is 1.")
            .MaximumLength(1024)
            .WithMessage("Minimum length for path is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for path must match ^.*$.")
            .NotNull()
            .WithMessage("Field path is required and cannot be null.");
        RuleFor(ContainerGroupQueueConnection => ContainerGroupQueueConnection.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
        RuleFor(ContainerGroupQueueConnection => ContainerGroupQueueConnection.QueueName)
            .MinimumLength(2)
            .WithMessage("Minimum length for queue_name is 2.")
            .MaximumLength(63)
            .WithMessage("Minimum length for queue_name is 2.")
            .Matches(@"^[a-z][a-z0-9-]{0,61}[a-z0-9]$")
            .WithMessage(@"Pattern for queue_name must match ^[a-z][a-z0-9-]{0,61}[a-z0-9]$.")
            .NotNull()
            .WithMessage("Field queue_name is required and cannot be null.");
    }
}
