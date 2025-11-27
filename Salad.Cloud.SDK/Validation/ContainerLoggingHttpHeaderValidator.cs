namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingHttpHeaderValidator : AbstractValidator<ContainerLoggingHttpHeader?>
{
    public ContainerLoggingHttpHeaderValidator()
    {
        RuleFor(ContainerLoggingHttpHeader => ContainerLoggingHttpHeader.Name)
            .MinimumLength(1)
            .WithMessage("Minimum length for name is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for name is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for name must match ^.*$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(ContainerLoggingHttpHeader => ContainerLoggingHttpHeader.Value)
            .MinimumLength(1)
            .WithMessage("Minimum length for value is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for value is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for value must match ^.*$.")
            .NotNull()
            .WithMessage("Field value is required and cannot be null.");
    }
}
