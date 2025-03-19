using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for inference endpoint job</summary>
public record InferenceEndpointJobEvent(
    /// <value>The action that was taken on the inference endpoint job.</value>
    [property: JsonPropertyName("action")]
        InferenceEndpointJobEventAction Action,
    /// <value>The time the event occurred.</value>
    [property: JsonPropertyName("time")]
        string Time
);
