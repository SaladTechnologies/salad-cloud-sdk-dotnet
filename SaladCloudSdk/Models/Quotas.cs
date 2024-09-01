using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents the organization quotas</summary>
public record Quotas(
    [property: JsonPropertyName("container_groups_quotas")]
        ContainerGroupsQuotas ContainerGroupsQuotas,
    [property: JsonPropertyName("recipes_quotas")] RecipesQuotas RecipesQuotas,
    /// <value>The time the resource was created</value>
    [property:
        JsonPropertyName("create_time"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreateTime = null,
    /// <value>The time the resource was last updated</value>
    [property:
        JsonPropertyName("update_time"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdateTime = null
);
