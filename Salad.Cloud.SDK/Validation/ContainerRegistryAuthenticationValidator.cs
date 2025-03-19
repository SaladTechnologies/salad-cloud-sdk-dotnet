namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerRegistryAuthenticationValidator
    : AbstractValidator<ContainerRegistryAuthentication?>
{
    public ContainerRegistryAuthenticationValidator()
    {
        RuleFor(ContainerRegistryAuthentication => ContainerRegistryAuthentication.AwsEcr)
            .Custom(
                (containerRegistryAuthenticationAwsEcr, context) =>
                {
                    if (containerRegistryAuthenticationAwsEcr != null)
                    {
                        var validator = new ContainerRegistryAuthenticationAwsEcrValidator();
                        var result = validator.Validate(containerRegistryAuthenticationAwsEcr);
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
        RuleFor(ContainerRegistryAuthentication => ContainerRegistryAuthentication.Basic)
            .Custom(
                (containerRegistryAuthenticationBasic, context) =>
                {
                    if (containerRegistryAuthenticationBasic != null)
                    {
                        var validator = new ContainerRegistryAuthenticationBasicValidator();
                        var result = validator.Validate(containerRegistryAuthenticationBasic);
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
        RuleFor(ContainerRegistryAuthentication => ContainerRegistryAuthentication.DockerHub)
            .Custom(
                (containerRegistryAuthenticationDockerHub, context) =>
                {
                    if (containerRegistryAuthenticationDockerHub != null)
                    {
                        var validator = new ContainerRegistryAuthenticationDockerHubValidator();
                        var result = validator.Validate(containerRegistryAuthenticationDockerHub);
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
        RuleFor(ContainerRegistryAuthentication => ContainerRegistryAuthentication.GcpGar)
            .Custom(
                (containerRegistryAuthenticationGcpGar, context) =>
                {
                    if (containerRegistryAuthenticationGcpGar != null)
                    {
                        var validator = new ContainerRegistryAuthenticationGcpGarValidator();
                        var result = validator.Validate(containerRegistryAuthenticationGcpGar);
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
        RuleFor(ContainerRegistryAuthentication => ContainerRegistryAuthentication.GcpGcr)
            .Custom(
                (containerRegistryAuthenticationGcpGcr, context) =>
                {
                    if (containerRegistryAuthenticationGcpGcr != null)
                    {
                        var validator = new ContainerRegistryAuthenticationGcpGcrValidator();
                        var result = validator.Validate(containerRegistryAuthenticationGcpGcr);
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
