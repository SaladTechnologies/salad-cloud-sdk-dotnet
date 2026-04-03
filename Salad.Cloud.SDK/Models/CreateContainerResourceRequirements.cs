using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Specifies the resource requirements for creating a container.</summary>
public class CreateContainerResourceRequirements
{
    /// <value>The number of CPU cores to allocate to the container (between 1 and 1024).</value>
    [JsonPropertyName("cpu")]
    public long Cpu { get; init; }

    /// <value>The amount of memory to allocate to the container in megabytes (between 1024 and 1073741824).</value>
    [JsonPropertyName("memory")]
    public long Memory { get; init; }

    /// <value>A list of GPU class UUIDs required by the container. Can be null if no GPU is required.</value>
    [JsonPropertyName("gpu_classes"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? GpuClasses { get; init; }

    /// <value>The amount of shared memory to allocate to the container via `/dev/shm` in megabytes (between 64 and 1073741824). If not specified, defaults to 64 MB.</value>
    [JsonPropertyName("shm_size"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? ShmSize { get; init; }

    /// <value>The amount of storage to allocate to the container in bytes (between 1 GB and 1 PB).</value>
    [
        JsonPropertyName("storage_amount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? StorageAmount { get; init; }

    // Constructor with defaults applied
    public CreateContainerResourceRequirements(
        long cpu,
        long memory,
        List<string>? gpu_classes = null,
        long? shm_size = null,
        long? storage_amount = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(CreateContainerResourceRequirements)} {{Cpu = {Cpu}, Memory = {Memory}, GpuClasses = {GpuClasses}, ShmSize = {ShmSize}, StorageAmount = {StorageAmount}}}";
    }
}
