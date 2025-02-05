namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateContainerValidator : AbstractValidator<UpdateContainer?>
{
    public UpdateContainerValidator()
    {
        RuleFor(UpdateContainer => UpdateContainer.Image)
            .MinimumLength(1)
            .WithMessage("Minimum length for image is 1.")
            .MaximumLength(1024)
            .WithMessage("Minimum length for image is 1.");
        RuleFor(UpdateContainer => UpdateContainer.Resources1)
            .Custom(
                (resources, context) =>
                {
                    if (resources != null)
                    {
                        var validator = new ResourcesValidator();
                        var result = validator.Validate(resources);
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

        RuleFor(UpdateContainer => UpdateContainer.Logging)
            .Custom(
                (updateContainerLogging, context) =>
                {
                    if (updateContainerLogging != null)
                    {
                        var validator = new UpdateContainerLoggingValidator();
                        var result = validator.Validate(updateContainerLogging);
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
        RuleFor(UpdateContainer => UpdateContainer.RegistryAuthentication)
            .Custom(
                (updateContainerRegistryAuthentication, context) =>
                {
                    if (updateContainerRegistryAuthentication != null)
                    {
                        var validator = new UpdateContainerRegistryAuthenticationValidator();
                        var result = validator.Validate(updateContainerRegistryAuthentication);
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
