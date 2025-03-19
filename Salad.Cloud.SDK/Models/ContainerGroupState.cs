using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents the operational state of a container group during its lifecycle, including timing information, status, and instance distribution metrics. This state captures the current execution status, start and finish times, and provides visibility into the operational health across instances.</summary>
public record ContainerGroupState(
    /// <value>Timestamp when the container group execution finished or is expected to finish</value>
    [property: JsonPropertyName("finish_time")]
        string FinishTime,
    /// <value>A summary of container group instances categorized by their current lifecycle status</value>
    [property: JsonPropertyName("instance_status_counts")]
        ContainerGroupInstanceStatusCount InstanceStatusCounts,
    /// <value>Timestamp when the container group execution started</value>
    [property: JsonPropertyName("start_time")]
        string StartTime,
    /// <value>Represents the current operational state of a container group within the Salad platform.</value>
    [property: JsonPropertyName("status")]
        ContainerGroupStatus Status,
    /// <value>Optional textual description or notes about the current state of the container group</value>
    [property: JsonPropertyName("description")]
        string? Description = null
);
