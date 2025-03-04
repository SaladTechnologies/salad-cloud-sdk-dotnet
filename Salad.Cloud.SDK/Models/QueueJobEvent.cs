using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for queue job</summary>
public record QueueJobEvent(
    [property: JsonPropertyName("action")] Action Action1,
    [property: JsonPropertyName("time")] string Time
);
