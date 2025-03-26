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
            .WithMessage("Minimum length for image is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for image must match ^.*$.");

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
        RuleFor(UpdateContainer => UpdateContainer.Resources)
            .Custom(
                (containerResourceUpdateSchema, context) =>
                {
                    if (containerResourceUpdateSchema != null)
                    {
                        var validator = new ContainerResourceUpdateSchemaValidator();
                        var result = validator.Validate(containerResourceUpdateSchema);
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
