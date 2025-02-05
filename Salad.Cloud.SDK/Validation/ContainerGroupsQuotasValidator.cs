namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupsQuotasValidator : AbstractValidator<ContainerGroupsQuotas?>
{
    public ContainerGroupsQuotasValidator()
    {
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.MaxCreatedContainerGroups)
            .NotNull()
            .WithMessage("Field max_created_container_groups is required.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.ContainerInstanceQuota)
            .NotNull()
            .WithMessage("Field container_instance_quota is required.");
        RuleFor(ContainerGroupsQuotas =>
                ContainerGroupsQuotas.MaxContainerGroupReallocationsPerMinute
            )
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_reallocations_per_minute is 0.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.MaxContainerGroupRecreatesPerMinute)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_recreates_per_minute is 0.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.MaxContainerGroupRestartsPerMinute)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_restarts_per_minute is 0.");
    }
}
