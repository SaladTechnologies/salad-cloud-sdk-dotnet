using System.Text.Json.Serialization;
using Salad.Cloud.SDK.Json;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a inference endpoint job</summary>
public record InferenceEndpointJob(
    [property: JsonPropertyName("id")] string Id,
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>The inference endpoint name</value>
    [property: JsonPropertyName("inference_endpoint_name")]
        string InferenceEndpointName,
    [property: JsonPropertyName("status")] InferenceEndpointJobStatus Status,
    [property: JsonPropertyName("events")] List<InferenceEndpointJobEvent> Events,
    /// <value>The organization name</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
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
