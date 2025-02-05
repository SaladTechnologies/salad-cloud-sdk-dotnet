namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateContainerLoggingValidator : AbstractValidator<CreateContainerLogging?>
{
    public CreateContainerLoggingValidator()
    {
        RuleFor(CreateContainerLogging => CreateContainerLogging.Axiom)
            .Custom(
                (loggingAxiom2, context) =>
                {
                    if (loggingAxiom2 != null)
                    {
                        var validator = new LoggingAxiom2Validator();
                        var result = validator.Validate(loggingAxiom2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(CreateContainerLogging => CreateContainerLogging.Datadog)
            .Custom(
                (loggingDatadog2, context) =>
                {
                    if (loggingDatadog2 != null)
                    {
                        var validator = new LoggingDatadog2Validator();
                        var result = validator.Validate(loggingDatadog2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(CreateContainerLogging => CreateContainerLogging.NewRelic)
            .Custom(
                (loggingNewRelic2, context) =>
                {
                    if (loggingNewRelic2 != null)
                    {
                        var validator = new LoggingNewRelic2Validator();
                        var result = validator.Validate(loggingNewRelic2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(CreateContainerLogging => CreateContainerLogging.Splunk)
            .Custom(
                (loggingSplunk2, context) =>
                {
                    if (loggingSplunk2 != null)
                    {
                        var validator = new LoggingSplunk2Validator();
                        var result = validator.Validate(loggingSplunk2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(CreateContainerLogging => CreateContainerLogging.Tcp)
            .Custom(
                (loggingTcp2, context) =>
                {
                    if (loggingTcp2 != null)
                    {
                        var validator = new LoggingTcp2Validator();
                        var result = validator.Validate(loggingTcp2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
        RuleFor(CreateContainerLogging => CreateContainerLogging.Http)
            .Custom(
                (loggingHttp2, context) =>
                {
                    if (loggingHttp2 != null)
                    {
                        var validator = new LoggingHttp2Validator();
                        var result = validator.Validate(loggingHttp2);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            );
    }
}
