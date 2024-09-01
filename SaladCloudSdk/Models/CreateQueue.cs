using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a request to create a queue</summary>
public record CreateQueue(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("display_name")] string? DisplayName = null,
    /// <value>The description</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
