using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to create a inference endpoint job</summary>
public record InferenceEndpointJobPrototype(
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>The job metadata. May be any valid JSON.</value>
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Metadata = null,
    /// <value>The webhook URL to which the job results will be POSTed.</value>
    [property:
        JsonPropertyName("webhook"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Webhook = null,
    /// <value>The webhook URL to which the job results will be POSTed.</value>
    [property:
        JsonPropertyName("webhook_url"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? WebhookUrl = null
);
