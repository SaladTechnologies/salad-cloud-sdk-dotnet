using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines configuration for automatically scaling container instances based on queue length. The autoscaler monitors a queue and adjusts the number of running replicas to maintain the desired queue length.</summary>
public record QueueBasedAutoscalerConfiguration(
    /// <value>The target number of items in the queue that the autoscaler attempts to maintain by scaling the containers up or down</value>
    [property: JsonPropertyName("desired_queue_length")]
        long DesiredQueueLength,
    /// <value>The maximum number of instances the container can scale up to</value>
    [property: JsonPropertyName("max_replicas")]
        long MaxReplicas,
    /// <value>The minimum number of instances the container can scale down to, ensuring baseline availability</value>
    [property: JsonPropertyName("min_replicas")]
        long MinReplicas,
    /// <value>The maximum number of instances that can be removed per minute to prevent rapid downscaling</value>
    [property:
        JsonPropertyName("max_downscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxDownscalePerMinute = null,
    /// <value>The maximum number of instances that can be added per minute to prevent rapid upscaling</value>
    [property:
        JsonPropertyName("max_upscale_per_minute"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? MaxUpscalePerMinute = null,
    /// <value>The period (in seconds) in which the autoscaler checks the queue length and applies the scaling formula</value>
    [property:
        JsonPropertyName("polling_period"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PollingPeriod = null
);
