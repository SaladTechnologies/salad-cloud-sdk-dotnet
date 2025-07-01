namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerValidator : AbstractValidator<Container?>
{
    public ContainerValidator()
    {
        RuleFor(Container => Container.Command).NotNull().WithMessage("Field command is required.");
        RuleFor(Container => Container.Image)
            .MinimumLength(1)
            .WithMessage("Minimum length for image is 1.")
            .MaximumLength(2048)
            .WithMessage("Minimum length for image is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for image must match ^.*$.")
            .NotNull()
            .WithMessage("Field image is required.");
        RuleFor(Container => Container.Resources)
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

        RuleFor(Container => Container.Hash)
            .MinimumLength(47)
            .WithMessage("Minimum length for hash is 47.")
            .MaximumLength(135)
            .WithMessage("Minimum length for hash is 47.")
            .Matches(@"^sha\d{1,3}:[a-fA-F0-9]{40,135}$")
            .WithMessage(@"Pattern for hash must match ^sha\d{1,3}:[a-fA-F0-9]{40,135}$.");

        RuleFor(Container => Container.Logging)
            .Custom(
                (containerLogging, context) =>
                {
                    if (containerLogging != null)
                    {
                        var validator = new ContainerLoggingValidator();
                        var result = validator.Validate(containerLogging);
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
        RuleFor(Container => Container.Size)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for size is 0.")
            .LessThanOrEqualTo(9223372036854775807)
            .WithMessage("Minimum for size is 9223372036854775807.");
    }
}
