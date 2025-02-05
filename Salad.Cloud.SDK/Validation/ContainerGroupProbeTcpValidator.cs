namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupProbeTcpValidator : AbstractValidator<ContainerGroupProbeTcp?>
{
    public ContainerGroupProbeTcpValidator()
    {
        RuleFor(ContainerGroupProbeTcp => ContainerGroupProbeTcp.Port)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for port is 0.")
            .LessThanOrEqualTo(65536)
            .WithMessage("Minimum for port is 65536.")
            .NotNull()
            .WithMessage("Field port is required.");
    }
}
