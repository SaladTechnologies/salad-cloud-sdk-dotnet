namespace Salad.Cloud.SDK.Validation;

using FluentValidation;
using FluentValidation.Results;
using Salad.Cloud.SDK.Models;

public class ContainerGroupsQuotasValidator : AbstractValidator<ContainerGroupsQuotas?>
{
    public ContainerGroupsQuotasValidator()
    {
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.ContainerReplicasQuota)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for container_replicas_quota is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for container_replicas_quota is 2147483647.")
            .NotNull()
            .WithMessage("Field container_replicas_quota is required.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.ContainerReplicasUsed)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for container_replicas_used is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for container_replicas_used is 2147483647.")
            .NotNull()
            .WithMessage("Field container_replicas_used is required.");
        RuleFor(ContainerGroupsQuotas =>
                ContainerGroupsQuotas.MaxContainerGroupReallocationsPerMinute
            )
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_reallocations_per_minute is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for max_container_group_reallocations_per_minute is 2147483647.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.MaxContainerGroupRecreatesPerMinute)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_recreates_per_minute is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for max_container_group_recreates_per_minute is 2147483647.");
        RuleFor(ContainerGroupsQuotas => ContainerGroupsQuotas.MaxContainerGroupRestartsPerMinute)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Minimum for max_container_group_restarts_per_minute is 0.")
            .LessThanOrEqualTo(2147483647)
            .WithMessage("Minimum for max_container_group_restarts_per_minute is 2147483647.");
    }
}
