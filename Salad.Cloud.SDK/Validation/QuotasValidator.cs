namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for Quotas model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class QuotasValidator : AbstractValidator<Quotas>
{
    public QuotasValidator()
    {
        RuleFor(Quotas => Quotas.ContainerGroupsQuotas)
            .Custom(
                (containerGroupsQuotas, context) =>
                {
                    if (containerGroupsQuotas != null)
                    {
                        var validator = new ContainerGroupsQuotasValidator();
                        var result = validator.Validate(containerGroupsQuotas);
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
            .WithMessage("Field container_groups_quotas is required and cannot be null.");
    }
}
