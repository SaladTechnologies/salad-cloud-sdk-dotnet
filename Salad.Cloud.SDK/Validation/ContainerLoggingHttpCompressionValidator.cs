namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerLoggingHttpCompression model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerLoggingHttpCompressionValidator
    : AbstractValidator<ContainerLoggingHttpCompression>
{
    public ContainerLoggingHttpCompressionValidator() { }
}
