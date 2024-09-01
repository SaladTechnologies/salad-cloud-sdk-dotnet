using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a request to update a queue</summary>
public record UpdateQueue(
    [property: JsonPropertyName("display_name")] string? DisplayName = null,
    /// <value>The description</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
