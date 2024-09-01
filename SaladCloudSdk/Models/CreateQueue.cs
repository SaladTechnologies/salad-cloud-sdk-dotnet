using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a request to create a new queue.</summary>
public record CreateQueue(
    /// <value>The queue name. This must be unique within the project.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The display name. This may be used as a more human-readable name.</value>
    [property: JsonPropertyName("display_name")]
        string? DisplayName = null,
    /// <value>The description. This may be used as a space for notes or other information about the queue.</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
