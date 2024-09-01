using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a request to create a inference endpoint job</summary>
public record CreateInferenceEndpointJob(
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    [property: JsonPropertyName("metadata")] object? Metadata = null,
    [property: JsonPropertyName("webhook")] string? Webhook = null
);
