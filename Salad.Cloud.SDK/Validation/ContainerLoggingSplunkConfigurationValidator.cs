namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingSplunkConfigurationValidator
    : AbstractValidator<ContainerLoggingSplunkConfiguration?>
{
    public ContainerLoggingSplunkConfigurationValidator()
    {
        RuleFor(ContainerLoggingSplunkConfiguration => ContainerLoggingSplunkConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(ContainerLoggingSplunkConfiguration => ContainerLoggingSplunkConfiguration.Token)
            .MinimumLength(1)
            .WithMessage("Minimum length for token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for token is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for token must match ^.*$.")
            .NotNull()
            .WithMessage("Field token is required.");
    }
}
