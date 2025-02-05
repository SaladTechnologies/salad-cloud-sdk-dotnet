namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class HttpHeaders4Validator : AbstractValidator<HttpHeaders4?>
{
    public HttpHeaders4Validator()
    {
        RuleFor(HttpHeaders4 => HttpHeaders4.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(HttpHeaders4 => HttpHeaders4.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
