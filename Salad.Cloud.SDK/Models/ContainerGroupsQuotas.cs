using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the organization quotas for container groups</summary>
public record ContainerGroupsQuotas(
    /// <value>The maximum number of container groups that can be created</value>
    [property:
        JsonPropertyName("max_created_container_groups"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxCreatedContainerGroups = null,
    /// <value>The maximum number of replicas that can be created for a container group</value>
    [property:
        JsonPropertyName("container_instance_quota"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ContainerInstanceQuota = null,
    /// <value>The maximum number of replicas that can be created for a container group</value>
    [property:
        JsonPropertyName("container_replica_quota"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ContainerReplicaQuota = null,
    /// <value>The number of replicas that are currently in use</value>
    [property:
        JsonPropertyName("container_replicas_used"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ContainerReplicasUsed = null,
    /// <value>The maximum number of container group reallocations per minute</value>
    [property:
        JsonPropertyName("max_container_group_reallocations_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupReallocationsPerMinute = null,
    /// <value>The maximum number of container group recreates per minute</value>
    [property:
        JsonPropertyName("max_container_group_recreates_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupRecreatesPerMinute = null,
    /// <value>The maximum number of container group restarts per minute</value>
    [property:
        JsonPropertyName("max_container_group_restarts_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupRestartsPerMinute = null
);
