namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class CreateContainerRegistryAuthenticationValidator
    : AbstractValidator<CreateContainerRegistryAuthentication?>
{
    public CreateContainerRegistryAuthenticationValidator()
    {
        RuleFor(CreateContainerRegistryAuthentication =>
                CreateContainerRegistryAuthentication.Basic
            )
            .Custom(
                (registryAuthenticationBasic1, context) =>
                {
                    if (registryAuthenticationBasic1 != null)
                    {
                        var validator = new RegistryAuthenticationBasic1Validator();
                        var result = validator.Validate(registryAuthenticationBasic1);
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
        RuleFor(CreateContainerRegistryAuthentication =>
                CreateContainerRegistryAuthentication.GcpGcr
            )
            .Custom(
                (registryAuthenticationGcpGcr1, context) =>
                {
                    if (registryAuthenticationGcpGcr1 != null)
                    {
                        var validator = new RegistryAuthenticationGcpGcr1Validator();
                        var result = validator.Validate(registryAuthenticationGcpGcr1);
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
        RuleFor(CreateContainerRegistryAuthentication =>
                CreateContainerRegistryAuthentication.AwsEcr
            )
            .Custom(
                (registryAuthenticationAwsEcr1, context) =>
                {
                    if (registryAuthenticationAwsEcr1 != null)
                    {
                        var validator = new RegistryAuthenticationAwsEcr1Validator();
                        var result = validator.Validate(registryAuthenticationAwsEcr1);
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
        RuleFor(CreateContainerRegistryAuthentication =>
                CreateContainerRegistryAuthentication.DockerHub
            )
            .Custom(
                (registryAuthenticationDockerHub1, context) =>
                {
                    if (registryAuthenticationDockerHub1 != null)
                    {
                        var validator = new RegistryAuthenticationDockerHub1Validator();
                        var result = validator.Validate(registryAuthenticationDockerHub1);
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
        RuleFor(CreateContainerRegistryAuthentication =>
                CreateContainerRegistryAuthentication.GcpGar
            )
            .Custom(
                (registryAuthenticationGcpGar1, context) =>
                {
                    if (registryAuthenticationGcpGar1 != null)
                    {
                        var validator = new RegistryAuthenticationGcpGar1Validator();
                        var result = validator.Validate(registryAuthenticationGcpGar1);
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
