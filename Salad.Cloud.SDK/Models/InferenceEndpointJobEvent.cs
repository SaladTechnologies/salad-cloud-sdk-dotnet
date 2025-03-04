using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for inference endpoint job</summary>
public record InferenceEndpointJobEvent(
    [property: JsonPropertyName("action")] InferenceEndpointJobEventAction Action,
    [property: JsonPropertyName("time")] string Time
);
