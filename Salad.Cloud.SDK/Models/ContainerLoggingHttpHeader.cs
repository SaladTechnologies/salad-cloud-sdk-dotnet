using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an HTTP header used for container logging configuration.</summary>
public record ContainerLoggingHttpHeader(
    /// <value>The name of the HTTP header</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The value of the HTTP header</value>
    [property: JsonPropertyName("value")]
        string Value
);
