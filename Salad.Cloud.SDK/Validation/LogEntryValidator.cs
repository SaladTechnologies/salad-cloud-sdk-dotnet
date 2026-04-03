namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for LogEntry model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class LogEntryValidator : AbstractValidator<LogEntry>
{
    public LogEntryValidator()
    {
        RuleFor(LogEntry => LogEntry.ReceiveTime)
            .NotNull()
            .WithMessage("Field receive_time is required and cannot be null.");
        RuleFor(LogEntry => LogEntry.Resource)
            .Custom(
                (logEntryResource, context) =>
                {
                    if (logEntryResource != null)
                    {
                        var validator = new LogEntryResourceValidator();
                        var result = validator.Validate(logEntryResource);
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
            .WithMessage("Field resource is required and cannot be null.");
        RuleFor(LogEntry => LogEntry.Severity_)
            .NotNull()
            .WithMessage("Field severity is required and cannot be null.");
        RuleFor(LogEntry => LogEntry.Time)
            .NotNull()
            .WithMessage("Field time is required and cannot be null.");

        RuleFor(LogEntry => LogEntry.ParentSpanId)
            .MinimumLength(1)
            .WithMessage("Minimum length for parent_span_id is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for parent_span_id is 1.");
        RuleFor(LogEntry => LogEntry.SpanId)
            .MinimumLength(1)
            .WithMessage("Minimum length for span_Id is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for span_Id is 1.");
        RuleFor(LogEntry => LogEntry.TextLog)
            .MaximumLength(10000)
            .WithMessage("Minimum length for text_log is 0.");
        RuleFor(LogEntry => LogEntry.TraceId)
            .MinimumLength(1)
            .WithMessage("Minimum length for trace_Id is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for trace_Id is 1.");
    }
}
