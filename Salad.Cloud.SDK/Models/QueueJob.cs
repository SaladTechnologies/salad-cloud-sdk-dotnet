using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a queue job</summary>
public record QueueJob(
    [property: JsonPropertyName("id")] string Id,
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    [property: JsonPropertyName("status")] QueueJobStatus Status,
    [property: JsonPropertyName("events")] List<QueueJobEvent> Events,
    [property: JsonPropertyName("create_time")] string CreateTime,
    [property: JsonPropertyName("update_time")] string UpdateTime,
    [property: JsonPropertyName("metadata")] object? Metadata = null,
    [property: JsonPropertyName("webhook")] string? Webhook = null,
    /// <value>The job output. May be any valid JSON.</value>
    [property:
        JsonPropertyName("output"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Output = null
);
