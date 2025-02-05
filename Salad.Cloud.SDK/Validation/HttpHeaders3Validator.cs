namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class HttpHeaders3Validator : AbstractValidator<HttpHeaders3?>
{
    public HttpHeaders3Validator()
    {
        RuleFor(HttpHeaders3 => HttpHeaders3.Name).NotNull().WithMessage("Field name is required.");
        RuleFor(HttpHeaders3 => HttpHeaders3.Value)
            .NotNull()
            .WithMessage("Field value is required.");
    }
}
