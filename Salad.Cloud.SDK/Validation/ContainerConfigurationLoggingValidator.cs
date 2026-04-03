namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

/// <summary>
/// FluentValidation validator for ContainerConfigurationLogging model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ContainerConfigurationLoggingValidator
    : AbstractValidator<ContainerConfigurationLogging>
{
    public ContainerConfigurationLoggingValidator()
    {
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.Axiom)
            .Custom(
                (axiomLoggingConfiguration, context) =>
                {
                    if (axiomLoggingConfiguration != null)
                    {
                        var validator = new AxiomLoggingConfigurationValidator();
                        var result = validator.Validate(axiomLoggingConfiguration);
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
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.Datadog)
            .Custom(
                (datadogLoggingConfiguration, context) =>
                {
                    if (datadogLoggingConfiguration != null)
                    {
                        var validator = new DatadogLoggingConfigurationValidator();
                        var result = validator.Validate(datadogLoggingConfiguration);
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
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.Http)
            .Custom(
                (containerLoggingConfigurationHttp2, context) =>
                {
                    if (containerLoggingConfigurationHttp2 != null)
                    {
                        var validator = new ContainerLoggingConfigurationHttp2Validator();
                        var result = validator.Validate(containerLoggingConfigurationHttp2);
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
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.NewRelic)
            .Custom(
                (newRelicLoggingConfiguration, context) =>
                {
                    if (newRelicLoggingConfiguration != null)
                    {
                        var validator = new NewRelicLoggingConfigurationValidator();
                        var result = validator.Validate(newRelicLoggingConfiguration);
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
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.Splunk)
            .Custom(
                (containerLoggingSplunkConfiguration, context) =>
                {
                    if (containerLoggingSplunkConfiguration != null)
                    {
                        var validator = new ContainerLoggingSplunkConfigurationValidator();
                        var result = validator.Validate(containerLoggingSplunkConfiguration);
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
        RuleFor(ContainerConfigurationLogging => ContainerConfigurationLogging.Tcp)
            .Custom(
                (tcpLoggingConfiguration, context) =>
                {
                    if (tcpLoggingConfiguration != null)
                    {
                        var validator = new TcpLoggingConfigurationValidator();
                        var result = validator.Validate(tcpLoggingConfiguration);
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
