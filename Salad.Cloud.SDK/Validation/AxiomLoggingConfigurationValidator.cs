namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class AxiomLoggingConfigurationValidator : AbstractValidator<AxiomLoggingConfiguration?>
{
    public AxiomLoggingConfigurationValidator()
    {
        RuleFor(AxiomLoggingConfiguration => AxiomLoggingConfiguration.Host)
            .MinimumLength(1)
            .WithMessage("Minimum length for host is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for host is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for host must match ^.*$.")
            .NotNull()
            .WithMessage("Field host is required.");
        RuleFor(AxiomLoggingConfiguration => AxiomLoggingConfiguration.ApiToken)
            .MinimumLength(1)
            .WithMessage("Minimum length for api_token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for api_token is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for api_token must match ^.*$.")
            .NotNull()
            .WithMessage("Field api_token is required.");
        RuleFor(AxiomLoggingConfiguration => AxiomLoggingConfiguration.Dataset)
            .MinimumLength(1)
            .WithMessage("Minimum length for dataset is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for dataset is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for dataset must match ^.*$.")
            .NotNull()
            .WithMessage("Field dataset is required.");
    }
}
