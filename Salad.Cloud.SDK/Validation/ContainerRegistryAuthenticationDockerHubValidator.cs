namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerRegistryAuthenticationDockerHubValidator
    : AbstractValidator<ContainerRegistryAuthenticationDockerHub?>
{
    public ContainerRegistryAuthenticationDockerHubValidator()
    {
        RuleFor(ContainerRegistryAuthenticationDockerHub =>
                ContainerRegistryAuthenticationDockerHub.Username
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for username is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for username is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for username must match ^.*$.")
            .NotNull()
            .WithMessage("Field username is required.");
        RuleFor(ContainerRegistryAuthenticationDockerHub =>
                ContainerRegistryAuthenticationDockerHub.PersonalAccessToken
            )
            .MinimumLength(1)
            .WithMessage("Minimum length for personal_access_token is 1.")
            .MaximumLength(1000)
            .WithMessage("Minimum length for personal_access_token is 1.")
            .Matches(@"^.*$")
            .WithMessage(@"Pattern for personal_access_token must match ^.*$.")
            .NotNull()
            .WithMessage("Field personal_access_token is required.");
    }
}
