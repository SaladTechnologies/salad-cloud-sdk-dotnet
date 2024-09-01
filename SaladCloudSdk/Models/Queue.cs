using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a queue.</summary>
public record Queue(
    /// <value>The queue identifier. This is automatically generated and assigned when the queue is created.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The queue name. This must be unique within the project.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The display name. This may be used as a more human-readable name.</value>
    [property: JsonPropertyName("display_name")]
        string DisplayName,
    [property: JsonPropertyName("container_groups")] List<ContainerGroup> ContainerGroups,
    /// <value>The date and time the queue was created.</value>
    [property: JsonPropertyName("create_time")]
        string CreateTime,
    /// <value>The date and time the queue was last updated.</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>The description. This may be used as a space for notes or other information about the queue.</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
