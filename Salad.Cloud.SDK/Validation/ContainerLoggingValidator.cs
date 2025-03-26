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
        RuleFor(ContainerLogging => ContainerLogging.Datadog)
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
        RuleFor(ContainerLogging => ContainerLogging.Http)
            .Custom(
                (containerLoggingConfigurationHttp1, context) =>
                {
                    if (containerLoggingConfigurationHttp1 != null)
                    {
                        var validator = new ContainerLoggingConfigurationHttp1Validator();
                        var result = validator.Validate(containerLoggingConfigurationHttp1);
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
        RuleFor(ContainerLogging => ContainerLogging.Splunk)
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
        RuleFor(ContainerLogging => ContainerLogging.Tcp)
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
