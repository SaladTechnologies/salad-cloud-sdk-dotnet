using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a queue</summary>
public record Queue(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("display_name")] string DisplayName,
    [property: JsonPropertyName("container_groups")] List<ContainerGroup> ContainerGroups,
    [property: JsonPropertyName("create_time")] string CreateTime,
    [property: JsonPropertyName("update_time")] string UpdateTime,
    /// <value>The description</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
