namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingConfigurationHttp1Validator
    : AbstractValidator<ContainerLoggingConfigurationHttp1?>
{
    public ContainerLoggingConfigurationHttp1Validator()
    {
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Format)
            .NotNull()
            .WithMessage("Field format is required.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Headers)
            .NotNull()
            .WithMessage("Field headers is required.");
        RuleFor(ContainerLoggingConfigurationHttp1 =>
                ContainerLoggingConfigurationHttp1.Compression
            )
            .NotNull()
            .WithMessage("Field compression is required.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.User)
            .MinimumLength(1)
            .WithMessage("Minimum length for user is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for user is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for user must match ^.*$.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Password)
            .MinimumLength(1)
            .WithMessage("Minimum length for password is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for password is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for password must match ^.*$.");
        RuleFor(ContainerLoggingConfigurationHttp1 => ContainerLoggingConfigurationHttp1.Path)
            .MinimumLength(1)
            .WithMessage("Minimum length for path is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for path is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for path must match ^.*$.");
    }
}
