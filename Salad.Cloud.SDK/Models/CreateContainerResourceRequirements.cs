using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Specifies the resource requirements for creating a container.</summary>
public record CreateContainerResourceRequirements(
    /// <value>The number of CPU cores required by the container. Must be between 1 and 16.</value>
    [property: JsonPropertyName("cpu")]
        long Cpu,
    /// <value>The amount of memory (in MB) required by the container. Must be between 1024 MB and 61440 MB.</value>
    [property: JsonPropertyName("memory")]
        long Memory,
    /// <value>A list of GPU class UUIDs required by the container. Can be null if no GPU is required.</value>
    [property:
        JsonPropertyName("gpu_classes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? GpuClasses = null,
    /// <value>The amount of storage (in bytes) required by the container. Must be between 1 GB (1073741824 bytes) and 250 GB (268435456000 bytes).</value>
    [property:
        JsonPropertyName("storage_amount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? StorageAmount = null
);
