namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerHttpLoggingConfigurationValidator
    : AbstractValidator<ContainerHttpLoggingConfiguration?>
{
    public ContainerHttpLoggingConfigurationValidator()
    {
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Port)
            .GreaterThanOrEqualTo(1)
            .WithMessage("Minimum for port is 1.")
            .LessThanOrEqualTo(65535)
            .WithMessage("Minimum for port is 65535.")
            .NotNull()
            .WithMessage("Field port is required.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Format1)
            .NotNull()
            .WithMessage("Field format is required.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Headers)
            .NotNull()
            .WithMessage("Field headers is required.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Compression1)
            .NotNull()
            .WithMessage("Field compression is required.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.User)
            .MinimumLength(1)
            .WithMessage("Minimum length for user is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for user is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for user must match ^.*$.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Password)
            .MinimumLength(1)
            .WithMessage("Minimum length for password is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for password is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for password must match ^.*$.");
        RuleFor(ContainerHttpLoggingConfiguration => ContainerHttpLoggingConfiguration.Path)
            .MinimumLength(1)
            .WithMessage("Minimum length for path is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for path is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for path must match ^.*$.");
    }
}
