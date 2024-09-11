using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a list of inference endpoints</summary>
public record InferenceEndpointsList(
    /// <value>The list of items</value>
    [property: JsonPropertyName("items")]
        List<InferenceEndpoint> Items
);
