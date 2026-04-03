using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Specifies the resource requirements for a container.</summary>
public class ContainerResourceRequirements
{
    /// <value>The number of CPU cores required by the container. Must be between 1 and 16.</value>
    [JsonPropertyName("cpu")]
    public long Cpu { get; init; }

    /// <value>A list of GPU class UUIDs required by the container. Can be null if no GPU is required.</value>
    [JsonPropertyName("gpu_classes")]
    public List<string> GpuClasses { get; init; }

    /// <value>The amount of memory (in MB) required by the container. Must be between 1024 MB and 61440 MB.</value>
    [JsonPropertyName("memory")]
    public long Memory { get; init; }

    /// <value>The size of the shared memory (/dev/shm) in MB. If not specified, defaults to 1024MB.</value>
    [JsonPropertyName("shm_size"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? ShmSize { get; init; }

    /// <value>The amount of storage (in bytes) required by the container. Must be between 1 GB (1073741824 bytes) and 250 GB (268435456000 bytes).</value>
    [
        JsonPropertyName("storage_amount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? StorageAmount { get; init; }

    // Constructor with defaults applied
    public ContainerResourceRequirements(
        long cpu,
        List<string> gpu_classes,
        long memory,
        long? shm_size = null,
        long? storage_amount = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(ContainerResourceRequirements)} {{Cpu = {Cpu}, GpuClasses = {GpuClasses}, Memory = {Memory}, ShmSize = {ShmSize}, StorageAmount = {StorageAmount}}}";
    }
}
