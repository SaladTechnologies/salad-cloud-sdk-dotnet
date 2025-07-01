namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class LogEntrySeverityValidator : AbstractValidator<LogEntrySeverity?>
{
    public LogEntrySeverityValidator() { }
}
