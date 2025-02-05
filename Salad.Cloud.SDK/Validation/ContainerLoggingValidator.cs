namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingValidator : AbstractValidator<ContainerLogging?>
{
    public ContainerLoggingValidator()
    {
        RuleFor(ContainerLogging => ContainerLogging.Axiom)
            .Custom(
                (loggingAxiom1, context) =>
                {
                    if (loggingAxiom1 != null)
                    {
                        var validator = new LoggingAxiom1Validator();
                        var result = validator.Validate(loggingAxiom1);
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
        RuleFor(ContainerLogging => ContainerLogging.Datadog)
            .Custom(
                (loggingDatadog1, context) =>
                {
                    if (loggingDatadog1 != null)
                    {
                        var validator = new LoggingDatadog1Validator();
                        var result = validator.Validate(loggingDatadog1);
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
        RuleFor(ContainerLogging => ContainerLogging.NewRelic)
            .Custom(
                (loggingNewRelic1, context) =>
                {
                    if (loggingNewRelic1 != null)
                    {
                        var validator = new LoggingNewRelic1Validator();
                        var result = validator.Validate(loggingNewRelic1);
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
        RuleFor(ContainerLogging => ContainerLogging.Splunk)
            .Custom(
                (loggingSplunk1, context) =>
                {
                    if (loggingSplunk1 != null)
                    {
                        var validator = new LoggingSplunk1Validator();
                        var result = validator.Validate(loggingSplunk1);
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
        RuleFor(ContainerLogging => ContainerLogging.Tcp)
            .Custom(
                (loggingTcp1, context) =>
                {
                    if (loggingTcp1 != null)
                    {
                        var validator = new LoggingTcp1Validator();
                        var result = validator.Validate(loggingTcp1);
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
        RuleFor(ContainerLogging => ContainerLogging.Http)
            .Custom(
                (loggingHttp1, context) =>
                {
                    if (loggingHttp1 != null)
                    {
                        var validator = new LoggingHttp1Validator();
                        var result = validator.Validate(loggingHttp1);
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
