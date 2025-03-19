using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a workload error</summary>
public record WorkloadError(
    /// <value>The timestamp when the workload was initially allocated to a machine</value>
    [property: JsonPropertyName("allocated_at")]
        string AllocatedAt,
    /// <value>A detailed error message describing the nature and cause of the workload failure</value>
    [property: JsonPropertyName("detail")]
        string Detail,
    /// <value>The timestamp when the workload failure was detected or reported</value>
    [property: JsonPropertyName("failed_at")]
        string FailedAt,
    /// <value>The container group instance identifier.</value>
    [property: JsonPropertyName("instance_id")]
        string InstanceId,
    /// <value>The container group machine identifier.</value>
    [property: JsonPropertyName("machine_id")]
        string MachineId,
    /// <value>The schema version number for this error record, used for tracking error format changes</value>
    [property: JsonPropertyName("version")]
        long Version,
    /// <value>The timestamp when the workload started execution, or null if it failed before starting</value>
    [property:
        JsonPropertyName("started_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? StartedAt = null
);
