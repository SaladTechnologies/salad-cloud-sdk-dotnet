using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a request to create a inference endpoint job</summary>
public record CreateInferenceEndpointJob(
    /// <value>The job input. May be any valid JSON.</value>
    [property: JsonPropertyName("input")]
        object Input_,
    [property:
        JsonPropertyName("metadata"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Metadata = null,
    [property:
        JsonPropertyName("webhook"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Webhook = null,
    [property:
        JsonPropertyName("webhook_url"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? WebhookUrl = null
);
