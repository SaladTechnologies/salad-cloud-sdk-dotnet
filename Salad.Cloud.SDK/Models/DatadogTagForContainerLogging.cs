using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a Datadog tag used for container logging metadata.</summary>
public record DatadogTagForContainerLogging(
    /// <value>The name of the metadata tag.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The value of the metadata tag.</value>
    [property: JsonPropertyName("value")]
        string Value
);
