namespace Salad.Cloud.SDK.Validation;

using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// Fluent validator for lists with support for count and uniqueness constraints.
/// Provides chainable methods for adding validation rules to list properties.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
public class ListValidator<T> : AbstractValidator<List<T>?>
{
    /// <summary>
    /// Adds a maximum count constraint to the list. Null values are not validated.
    /// </summary>
    /// <param name="maxCount">The maximum number of items allowed in the list.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public ListValidator<T> WithMaximumCount(int maxCount)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list).Must(list => list == null || list.Count <= maxCount);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds a minimum count constraint to the list. Null values are not validated.
    /// </summary>
    /// <param name="minCount">The minimum number of items required in the list.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public ListValidator<T> WithMinimumCount(int minCount)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list).Must(list => list == null || list.Count >= minCount);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds a unique items constraint requiring all elements in the list to be distinct. Null values are not validated.
    /// </summary>
    /// <returns>This validator instance for method chaining.</returns>
    public ListValidator<T> WithUniqueItems()
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list)
                    .Must(list => list == null || list.Distinct().Count() == list.Count);
            }
        );
        return this;
    }

    /// <summary>
    /// Validates an optional list, allowing null values to pass validation.
    /// </summary>
    /// <param name="value">The list to validate.</param>
    /// <returns>Validation result indicating success or failure.</returns>
    public ValidationResult ValidateOptionalList(List<T>? value)
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return Validate(value);
    }

    /// <summary>
    /// Validates a required list, rejecting null values as validation failures.
    /// </summary>
    /// <param name="value">The list to validate.</param>
    /// <returns>Validation result indicating success or failure.</returns>
    public ValidationResult ValidateRequiredList(List<T>? value)
    {
        if (value == null)
        {
            return new ValidationResult(
                new[]
                {
                    new ValidationFailure(nameof(value), "Value is required and cannot be null."),
                }
            );
        }
        return Validate(value);
    }
}
