using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of inference endpoints</summary>
public record InferenceEndpointsList(
    /// <value>The list of items</value>
    [property: JsonPropertyName("items")]
        List<InferenceEndpoint> Items
);
