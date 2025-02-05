namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class HttpHeaders1Validator : AbstractValidator<HttpHeaders1?>
{
    public HttpHeaders1Validator()
    {
        RuleFor(HttpHeaders1 => HttpHeaders1.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(HttpHeaders1 => HttpHeaders1.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
