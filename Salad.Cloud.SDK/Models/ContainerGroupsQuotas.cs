using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupsQuotas(
    [property: JsonPropertyName("max_created_container_groups")] long MaxCreatedContainerGroups,
    [property: JsonPropertyName("container_instance_quota")] long ContainerInstanceQuota,
    [property:
        JsonPropertyName("max_container_group_reallocations_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupReallocationsPerMinute = null,
    [property:
        JsonPropertyName("max_container_group_recreates_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupRecreatesPerMinute = null,
    [property:
        JsonPropertyName("max_container_group_restarts_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxContainerGroupRestartsPerMinute = null
);
