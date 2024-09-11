using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a container group state</summary>
public record ContainerGroupState(
    [property: JsonPropertyName("status")] ContainerGroupStatus Status,
    [property: JsonPropertyName("start_time")] string StartTime,
    [property: JsonPropertyName("finish_time")] string FinishTime,
    /// <value>Represents a container group instance status count</value>
    [property: JsonPropertyName("instance_status_counts")]
        ContainerGroupInstanceStatusCount InstanceStatusCounts,
    [property: JsonPropertyName("description")] string? Description = null
);
