namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for LogEntrySeverity model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class LogEntrySeverityValidator : AbstractValidator<LogEntrySeverity>
{
    public LogEntrySeverityValidator() { }
}
