using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a scaling action configuration for a container group</summary>
public record ContainerGroupScalingAction(
    /// <value>The number of replicas to scale to during the scheduled period</value>
    [property: JsonPropertyName("replicas")]
        long Replicas,
    /// <value>The cron-style schedule string defining when the scaling should occur</value>
    [property: JsonPropertyName("schedule")]
        string Schedule
);
