using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a list of inference endpoint jobs</summary>
public record InferenceEndpointJobList(
    /// <value>The list of items</value>
    [property: JsonPropertyName("items")]
        List<InferenceEndpointJob> Items
);
