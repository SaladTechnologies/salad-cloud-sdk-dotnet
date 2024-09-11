using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the autoscaling rules for a queue</summary>
public record QueueAutoscaler(
    [property: JsonPropertyName("min_replicas")] long MinReplicas,
    [property: JsonPropertyName("max_replicas")] long MaxReplicas,
    [property: JsonPropertyName("desired_queue_length")] long DesiredQueueLength,
    [property:
        JsonPropertyName("polling_period"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PollingPeriod = null,
    [property:
        JsonPropertyName("max_upscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxUpscalePerMinute = null,
    [property:
        JsonPropertyName("max_downscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxDownscalePerMinute = null
);
