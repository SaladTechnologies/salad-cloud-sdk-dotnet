namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingConfigurationHttp2Validator
    : AbstractValidator<ContainerLoggingConfigurationHttp2?>
{
    public ContainerLoggingConfigurationHttp2Validator()
    {
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.Format)
            .NotNull()
            .WithMessage("Field format is required.");
        RuleFor(ContainerLoggingConfigurationHttp2 =>
                ContainerLoggingConfigurationHttp2.Compression
            )
            .NotNull()
            .WithMessage("Field compression is required.");
        RuleFor(ContainerLoggingConfigurationHttp2 => ContainerLoggingConfigurationHttp2.User)
            .MinimumLength(1)
            .WithMessage("Minimum length for user is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for user is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for user must match ^.*$.");
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
    }
}
