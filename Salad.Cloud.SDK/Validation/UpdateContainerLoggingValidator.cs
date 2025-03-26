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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Datadog)
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Http)
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.NewRelic)
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Splunk)
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
        RuleFor(UpdateContainerLogging => UpdateContainerLogging.Tcp)
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
