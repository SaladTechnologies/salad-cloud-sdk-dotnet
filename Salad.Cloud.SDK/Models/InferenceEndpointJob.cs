using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a inference endpoint job</summary>
public record InferenceEndpointJob(
    /// <value>The unique identifier.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>The inference endpoint name.</value>
    [property: JsonPropertyName("inference_endpoint_name")]
        string InferenceEndpointName,
    /// <value>The current status.</value>
    [property: JsonPropertyName("status")]
        InferenceEndpointJobStatus Status,
    /// <value>The list of events.</value>
    [property: JsonPropertyName("events")]
        List<InferenceEndpointJobEvent> Events,
    /// <value>The organization name.</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
    /// <value>The time the job was created.</value>
    [property: JsonPropertyName("create_time")]
        string CreateTime,
    /// <value>The time the job was last updated.</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>The job metadata. May be any valid JSON.</value>
    [property: JsonPropertyName("metadata")]
        object? Metadata = null,
    /// <value>The webhook URL called when the job completes.</value>
    [property: JsonPropertyName("webhook")]
        string? Webhook = null,
    /// <value>The job output. May be any valid JSON.</value>
    [property:
        JsonPropertyName("output"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Output = null
);
