namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerConfiguration model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerConfigurationValidator : AbstractValidator<ContainerConfiguration>
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
            .WithMessage("Field image is required and cannot be null.");
        RuleFor(ContainerConfiguration => ContainerConfiguration.Resources)
            .Custom(
                (createContainerResourceRequirements, context) =>
                {
                    if (createContainerResourceRequirements != null)
                    {
                        var validator = new CreateContainerResourceRequirementsValidator();
                        var result = validator.Validate(createContainerResourceRequirements);
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
            .WithMessage("Field resources is required and cannot be null.");

        RuleFor(ContainerConfiguration => ContainerConfiguration.Logging)
            .Custom(
                (containerConfigurationLogging, context) =>
                {
                    if (containerConfigurationLogging != null)
                    {
                        var validator = new ContainerConfigurationLoggingValidator();
                        var result = validator.Validate(containerConfigurationLogging);
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
