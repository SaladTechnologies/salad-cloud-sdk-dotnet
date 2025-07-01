using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>The resource associated with the log entry</summary>
public record LogEntryResource(
    /// <value>The labels associated with the resource</value>
    [property: JsonPropertyName("labels")]
        object Labels,
    /// <value>The type of the resource</value>
    [property: JsonPropertyName("type")]
        string Type_
);
