using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a queue job</summary>
public record QueueJob(
    /// <value>The job creation time</value>
    [property: JsonPropertyName("create_time")]
        string CreateTime,
    /// <value>The job events</value>
    [property: JsonPropertyName("events")]
        List<QueueJobEvent> Events,
    /// <value>The job identifier</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>The job status</value>
    [property: JsonPropertyName("status")]
        QueueJobStatus Status,
    /// <value>The job update time</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>Additional metadata for the job</value>
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Metadata = null,
    /// <value>The job output. May be any valid JSON.</value>
    [property:
        JsonPropertyName("output"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Output = null,
    /// <value>The webhook URL to notify when the job completes</value>
    [property:
        JsonPropertyName("webhook"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Webhook = null
);
