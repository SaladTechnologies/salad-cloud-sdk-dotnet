namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerLoggingConfigurationValidator
    : AbstractValidator<ContainerLoggingConfiguration?>
{
    public ContainerLoggingConfigurationValidator()
    {
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.Axiom)
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
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.Datadog)
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
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.Http)
            .Custom(
                (containerHttpLoggingConfiguration, context) =>
                {
                    if (containerHttpLoggingConfiguration != null)
                    {
                        var validator = new ContainerHttpLoggingConfigurationValidator();
                        var result = validator.Validate(containerHttpLoggingConfiguration);
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
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.NewRelic)
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
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.Splunk)
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
        RuleFor(ContainerLoggingConfiguration => ContainerLoggingConfiguration.Tcp)
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
