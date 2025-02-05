using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for inference endpoint job</summary>
public record InferenceEndpointJobEvent(
    [property: JsonPropertyName("action")] InferenceEndpointJobEventAction Action,
    [property: JsonPropertyName("time")] string Time
);
