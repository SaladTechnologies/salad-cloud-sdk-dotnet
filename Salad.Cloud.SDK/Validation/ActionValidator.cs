namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ActionValidator : AbstractValidator<Action?>
{
    public ActionValidator() { }
}
