using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a request to create a queue job</summary>
public record CreateQueueJob(
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    [property: JsonPropertyName("metadata")] object? Metadata = null,
    [property: JsonPropertyName("webhook")] string? Webhook = null
);
