using System.Text.Json.Serialization;

namespace SaladCloudSdk.Models;

/// <summary>Represents a workload error</summary>
public record WorkloadError(
    [property: JsonPropertyName("detail")] string Detail,
    [property: JsonPropertyName("failed_at")] string FailedAt,
    [property: JsonPropertyName("instance_id")] string InstanceId,
    [property: JsonPropertyName("machine_id")] string MachineId,
    [property: JsonPropertyName("allocated_at")] string AllocatedAt,
    [property: JsonPropertyName("version")] long Version,
    [property: JsonPropertyName("started_at")] string? StartedAt = null
);
