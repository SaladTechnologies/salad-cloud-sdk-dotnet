using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Represents a system log</summary>
public record SystemLog(
    /// <value>The name of the event</value>
    [property: JsonPropertyName("event_name")]
        string EventName,
    /// <value>The UTC date & time when the log item was created</value>
    [property: JsonPropertyName("event_time")]
        string EventTime,
    /// <value>The version instance ID</value>
    [property: JsonPropertyName("version")]
        string Version,
    /// <value>The number of CPUs</value>
    [property: JsonPropertyName("resource_cpu")]
        long ResourceCpu,
    /// <value>The memory amount in MB</value>
    [property: JsonPropertyName("resource_memory")]
        long ResourceMemory,
    /// <value>The GPU class name</value>
    [property: JsonPropertyName("resource_gpu_class")]
        string ResourceGpuClass,
    /// <value>The storage amount in bytes</value>
    [property: JsonPropertyName("resource_storage_amount")]
        long ResourceStorageAmount,
    /// <value>The unique instance ID</value>
    [property:
        JsonPropertyName("instance_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? InstanceId = null,
    /// <value>The organization-specific machine ID</value>
    [property:
        JsonPropertyName("machine_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? MachineId = null
);
