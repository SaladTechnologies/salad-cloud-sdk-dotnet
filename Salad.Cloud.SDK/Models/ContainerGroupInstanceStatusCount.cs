using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A summary of container group instances categorized by their current lifecycle status</summary>
public record ContainerGroupInstanceStatusCount(
    /// <value>The number of container instances that are currently being allocated resources</value>
    [property: JsonPropertyName("allocating_count")]
        long AllocatingCount,
    /// <value>The number of container instances that are in the process of being created</value>
    [property: JsonPropertyName("creating_count")]
        long CreatingCount,
    /// <value>The number of container instances that are currently running and operational</value>
    [property: JsonPropertyName("running_count")]
        long RunningCount,
    /// <value>The number of container instances that are in the process of stopping</value>
    [property: JsonPropertyName("stopping_count")]
        long StoppingCount
);
