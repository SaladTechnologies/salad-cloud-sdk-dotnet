using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents an event for queue job</summary>
public record QueueJobEvent(
    /// <value>The action that was taken on the queue job</value>
    [property: JsonPropertyName("action")]
        Action Action1,
    /// <value>The time the action was taken on the queue job</value>
    [property: JsonPropertyName("time")]
        string Time
);
