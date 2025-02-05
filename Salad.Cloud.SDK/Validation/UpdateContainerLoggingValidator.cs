namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateContainerLoggingValidator : AbstractValidator<UpdateContainerLogging?>
{
    public UpdateContainerLoggingValidator()
    {
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Axiom)
            .Custom(
                (loggingAxiom3, context) =>
                {
                    if (loggingAxiom3 != null)
                    {
                        var validator = new LoggingAxiom3Validator();
                        var result = validator.Validate(loggingAxiom3);
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Datadog)
            .Custom(
                (loggingDatadog3, context) =>
                {
                    if (loggingDatadog3 != null)
                    {
                        var validator = new LoggingDatadog3Validator();
                        var result = validator.Validate(loggingDatadog3);
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.NewRelic)
            .Custom(
                (loggingNewRelic3, context) =>
                {
                    if (loggingNewRelic3 != null)
                    {
                        var validator = new LoggingNewRelic3Validator();
                        var result = validator.Validate(loggingNewRelic3);
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Splunk)
            .Custom(
                (loggingSplunk3, context) =>
                {
                    if (loggingSplunk3 != null)
                    {
                        var validator = new LoggingSplunk3Validator();
                        var result = validator.Validate(loggingSplunk3);
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Tcp)
            .Custom(
                (loggingTcp3, context) =>
                {
                    if (loggingTcp3 != null)
                    {
                        var validator = new LoggingTcp3Validator();
                        var result = validator.Validate(loggingTcp3);
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Http)
            .Custom(
                (loggingHttp3, context) =>
                {
                    if (loggingHttp3 != null)
                    {
                        var validator = new LoggingHttp3Validator();
                        var result = validator.Validate(loggingHttp3);
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
