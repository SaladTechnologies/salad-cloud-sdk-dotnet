namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerLoggingConfigurationHttp2 model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerLoggingConfigurationHttp2Validator
    : AbstractValidator<ContainerLoggingConfigurationHttp2>
{
    public ContainerLoggingConfigurationHttp2Validator()
    {
        RuleFor(ContainerLoggingConfigurationHttp2 =>
                ContainerLoggingConfigurationHttp2.Compression
            )
            .NotNull()
            .WithMessage("Field compression is required and cannot be null.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Format)
            .NotNull()
            .WithMessage("Field format is required and cannot be null.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required and cannot be null.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required and cannot be null.");

        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Password)
            .MinimumLength(1)
            .WithMessage("Minimum length for password is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for password is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for password must match ^.*$.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Path)
            .MinimumLength(1)
            .WithMessage("Minimum length for path is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for path is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for path must match ^.*$.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.User)
            .MinimumLength(1)
            .WithMessage("Minimum length for user is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for user is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for user must match ^.*$.");
    }
}
