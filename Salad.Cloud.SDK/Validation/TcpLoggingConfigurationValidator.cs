namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for TcpLoggingConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class TcpLoggingConfigurationValidator : AbstractValidator<TcpLoggingConfiguration>
{
    public TcpLoggingConfigurationValidator()
    {
        RuleFor(TcpLoggingConfiguration => TcpLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
        RuleFor(TcpLoggingConfiguration => TcpLoggingConfiguration.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");
    }
}
