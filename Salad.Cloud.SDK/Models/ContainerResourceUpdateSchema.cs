using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines the resource specifications that can be modified for a container group, including CPU, memory, GPU classes, and storage allocations.</summary>
public record ContainerResourceUpdateSchema(
    /// <value>The number of CPU cores to allocate to the container (between 1 and 16 cores).</value>
    [property: JsonPropertyName("cpu")]
        long? Cpu = null,
    /// <value>The amount of memory to allocate to the container in megabytes (between 1024MB and 61440MB).</value>
    [property: JsonPropertyName("memory")]
        long? Memory = null,
    /// <value>List of GPU class identifiers that the container can use, specified as UUIDs.</value>
    [property: JsonPropertyName("gpu_classes")]
        List<string>? GpuClasses = null,
    /// <value>The amount of storage to allocate to the container in bytes (between 1GB and 250GB).</value>
    [property: JsonPropertyName("storage_amount")]
        long? StorageAmount = null,
    /// <value>The size of the shared memory (/dev/shm) in MB. If not specified, defaults to 64MB.</value>
    [property: JsonPropertyName("shm_size")]
        long? ShmSize = null
);
