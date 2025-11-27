using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

public record InferenceEndpointJob(
    /// <value>The inference endpoint job identifier.</value>
    [property: JsonPropertyName("id")]
        string Id,
    /// <value>The inference endpoint name.</value>
    [property: JsonPropertyName("inference_endpoint_name")]
        string InferenceEndpointName,
    /// <value>The organization name.</value>
    [property: JsonPropertyName("organization_name")]
        string OrganizationName,
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>The current status.</value>
    [property: JsonPropertyName("status")]
        Status Status,
    /// <value>The list of events.</value>
    [property: JsonPropertyName("events")]
        List<InferenceEndpointJobEvent> Events,
    /// <value>The time the job was created.</value>
    [property: JsonPropertyName("create_time")]
        string CreateTime,
    /// <value>The time the job was last updated.</value>
    [property: JsonPropertyName("update_time")]
        string UpdateTime,
    /// <value>The job metadata. May be any valid JSON.</value>
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Metadata = null,
    /// <value>The webhook URL called when the job completes.</value>
    [property:
        JsonPropertyName("webhook"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Webhook = null,
    /// <value>The webhook URL called when the job completes.</value>
    [property:
        JsonPropertyName("webhook_url"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? WebhookUrl = null,
    /// <value>The job output. May be any valid JSON.</value>
    [property:
        JsonPropertyName("output"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Output = null
);
