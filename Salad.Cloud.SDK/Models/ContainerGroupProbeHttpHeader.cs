using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record ContainerGroupProbeHttpHeader(
    /// <value>The name of the HTTP header</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The value associated with the HTTP header</value>
    [property: JsonPropertyName("value")]
        string Value
);
