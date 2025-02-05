namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class UpdateContainerRegistryAuthenticationValidator
    : AbstractValidator<UpdateContainerRegistryAuthentication?>
{
    public UpdateContainerRegistryAuthenticationValidator()
    {
        RuleFor(UpdateContainerRegistryAuthentication =>
                UpdateContainerRegistryAuthentication.Basic
            )
            .Custom(
                (registryAuthenticationBasic2, context) =>
                {
                    if (registryAuthenticationBasic2 != null)
                    {
                        var validator = new RegistryAuthenticationBasic2Validator();
                        var result = validator.Validate(registryAuthenticationBasic2);
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
        RuleFor(UpdateContainerRegistryAuthentication =>
                UpdateContainerRegistryAuthentication.GcpGcr
            )
            .Custom(
                (registryAuthenticationGcpGcr2, context) =>
                {
                    if (registryAuthenticationGcpGcr2 != null)
                    {
                        var validator = new RegistryAuthenticationGcpGcr2Validator();
                        var result = validator.Validate(registryAuthenticationGcpGcr2);
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
        RuleFor(UpdateContainerRegistryAuthentication =>
                UpdateContainerRegistryAuthentication.AwsEcr
            )
            .Custom(
                (registryAuthenticationAwsEcr2, context) =>
                {
                    if (registryAuthenticationAwsEcr2 != null)
                    {
                        var validator = new RegistryAuthenticationAwsEcr2Validator();
                        var result = validator.Validate(registryAuthenticationAwsEcr2);
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
        RuleFor(UpdateContainerRegistryAuthentication =>
                UpdateContainerRegistryAuthentication.DockerHub
            )
            .Custom(
                (registryAuthenticationDockerHub2, context) =>
                {
                    if (registryAuthenticationDockerHub2 != null)
                    {
                        var validator = new RegistryAuthenticationDockerHub2Validator();
                        var result = validator.Validate(registryAuthenticationDockerHub2);
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
        RuleFor(UpdateContainerRegistryAuthentication =>
                UpdateContainerRegistryAuthentication.GcpGar
            )
            .Custom(
                (registryAuthenticationGcpGar2, context) =>
                {
                    if (registryAuthenticationGcpGar2 != null)
                    {
                        var validator = new RegistryAuthenticationGcpGar2Validator();
                        var result = validator.Validate(registryAuthenticationGcpGar2);
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
