namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateContainerValidator : AbstractValidator<CreateContainer?>
{
    public CreateContainerValidator()
    {
        RuleFor(CreateContainer => CreateContainer.Image)
            .MinimumLength(1)
            .WithMessage("Minimum length for image is 1.")
            .MaximumLength(1024)
            .WithMessage("Minimum length for image is 1.")
            .NotNull()
            .WithMessage("Field image is required.");
        RuleFor(CreateContainer => CreateContainer.Resources)
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

        RuleFor(CreateContainer => CreateContainer.Logging)
            .Custom(
                (createContainerLogging, context) =>
                {
                    if (createContainerLogging != null)
                    {
                        var validator = new CreateContainerLoggingValidator();
                        var result = validator.Validate(createContainerLogging);
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
        RuleFor(CreateContainer => CreateContainer.RegistryAuthentication)
            .Custom(
                (createContainerRegistryAuthentication, context) =>
                {
                    if (createContainerRegistryAuthentication != null)
                    {
                        var validator = new CreateContainerRegistryAuthenticationValidator();
                        var result = validator.Validate(createContainerRegistryAuthentication);
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
