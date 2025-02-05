using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the autoscaling rules for a queue</summary>
public record QueueAutoscaler(
    /// <value>The minimum number of instances the container can scale down to</value>
    [property: JsonPropertyName("min_replicas")]
        long MinReplicas,
    /// <value>The maximum number of instances the container can scale up to</value>
    [property: JsonPropertyName("max_replicas")]
        long MaxReplicas,
    [property: JsonPropertyName("desired_queue_length")] long DesiredQueueLength,
    /// <value>The period (in seconds) in which the queue checks the formula</value>
    [property:
        JsonPropertyName("polling_period"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PollingPeriod = null,
    /// <value>The maximum number of instances that can be added per minute</value>
    [property:
        JsonPropertyName("max_upscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxUpscalePerMinute = null,
    /// <value>The maximum number of instances that can be removed per minute</value>
    [property:
        JsonPropertyName("max_downscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxDownscalePerMinute = null
);
