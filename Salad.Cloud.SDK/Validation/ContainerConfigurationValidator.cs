namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerConfigurationValidator : AbstractValidator<ContainerConfiguration?>
{
    public ContainerConfigurationValidator()
    {
        RuleFor(ContainerConfiguration => ContainerConfiguration.Image)
            .MinimumLength(1)
            .WithMessage("Minimum length for image is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for image is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for image must match ^.*$.")
            .NotNull()
            .WithMessage("Field image is required.");
        RuleFor(ContainerConfiguration => ContainerConfiguration.Resources)
            .Custom(
                (containerResourceRequirements, context) =>
                {
                    if (containerResourceRequirements != null)
                    {
                        var validator = new ContainerResourceRequirementsValidator();
                        var result = validator.Validate(containerResourceRequirements);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            )
            .NotNull()
            .WithMessage("Field resources is required.");

        RuleFor(ContainerConfiguration => ContainerConfiguration.Logging)
            .Custom(
                (containerLoggingConfiguration, context) =>
                {
                    if (containerLoggingConfiguration != null)
                    {
                        var validator = new ContainerLoggingConfigurationValidator();
                        var result = validator.Validate(containerLoggingConfiguration);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );

        RuleFor(ContainerConfiguration => ContainerConfiguration.RegistryAuthentication)
            .Custom(
                (containerRegistryAuthentication, context) =>
                {
                    if (containerRegistryAuthentication != null)
                    {
                        var validator = new ContainerRegistryAuthenticationValidator();
                        var result = validator.Validate(containerRegistryAuthentication);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
    }
}
